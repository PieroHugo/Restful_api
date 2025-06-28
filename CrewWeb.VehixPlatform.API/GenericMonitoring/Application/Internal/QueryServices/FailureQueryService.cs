// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Queries;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Repositories;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Application.Internal.QueryServices;

public class FailureQueryService (IFailureRepository failureRepository) : IFailureQueryService
{
    public async Task<Failure?> Handle(GetFailureByIdQuery query)
    {
        return await failureRepository.FindByIdAsync(query.FailureId);
    }

    public async Task<IEnumerable<Failure>> Handle(GetAllFailuresQuery query)
    {
        return await failureRepository.ListAsync();
    }

    public async Task<IEnumerable<Failure>> Handle(GetAllFailuresByErrorTypeQuery query)
    {
        return await failureRepository.FindByErrorType(query.ErrorType);
    }
}