// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;

public interface IFailureCommandService
{
    public Task<Failure?> Handle(CreateFailureCommand command);
    
    Task<Failure?> Handle(AddBadPracticeToFailureCommand command);
    Task<Failure?> Handle(AddOdbErrorToFailureCommand command);


}
