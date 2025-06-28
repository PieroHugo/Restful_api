// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Queries;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;

public interface IOdbErrorQueryService
{
    Task<OdbError?> Handle(GetOdbErrorByIdQuery query);
    Task<IEnumerable<OdbError>> Handle(GetAllOdbErrorsQuery query);
}
