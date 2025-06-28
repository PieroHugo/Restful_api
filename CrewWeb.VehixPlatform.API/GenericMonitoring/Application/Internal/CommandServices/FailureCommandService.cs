// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Repositories;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;
using CrewWeb.VehixPlatform.API.Shared.Domain.Repositories;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Application.Internal.CommandServices;

public class FailureCommandService(
    IFailureRepository failureRepository,
    IBadPracticeRepository badPracticeRepository,
    IOdbErrorRepository odbErrorRepository,
    IUnitOfWork unitOfWork) : IFailureCommandService
{
    public async Task<Failure?> Handle(CreateFailureCommand command)
    {
        var badPractice = await badPracticeRepository.FindByIdAsync(command.BadPracticeId);
        if (badPractice is null) throw new Exception("Bad practice not found");
        var odbError = await odbErrorRepository.FindByIdAsync(command.OdbErrorId);
        if (odbError is null) throw new Exception("Odb error not found");
        
        
        var failure = new Failure(command);
        //Give you the failure and mark as "new" or "add". Maintain that in your pending changes list
        await failureRepository.AddAsync(failure);
        //collects all the changes it has been tracking
        await unitOfWork.CompleteAsync();
        
        failure.OdbError = odbError;
        failure.BadPractice = badPractice;
        return failure;
    }

    public async Task<Failure?> Handle(AddBadPracticeToFailureCommand command)
    {
        var failure = await failureRepository.FindByIdAsync(command.FailureId);
        if (failure is null) throw new Exception("Failure not found");
        failure.AddBadPracticeToFailure(command.DescriptionBadPractice);
        await unitOfWork.CompleteAsync();
        return failure;
    }

    public async Task<Failure?> Handle(AddOdbErrorToFailureCommand command)
    {
        var failure = await failureRepository.FindByIdAsync(command.FailureId);
        if (failure is null) throw new Exception("Failure not found");
        failure.AddOdbErrorToFailure(command.ErrorCode, command.ErrorCodeTitle, command.ErrorType);
        await unitOfWork.CompleteAsync();
        return failure;
    }
}