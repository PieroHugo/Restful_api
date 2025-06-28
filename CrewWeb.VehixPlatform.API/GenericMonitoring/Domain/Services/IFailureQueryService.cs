// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Queries;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;

public interface IFailureQueryService
{
    Task<Failure?> Handle(GetFailureByIdQuery query);
    Task<IEnumerable<Failure>> Handle(GetAllFailuresQuery query);
    
    Task<IEnumerable<Failure>> Handle(GetAllFailuresByErrorTypeQuery query);
}
