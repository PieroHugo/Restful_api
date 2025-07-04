// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Queries;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Repositories;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Application.Internal.QueryServices;

public class OdbErrorQueryService(IOdbErrorRepository odbErrorRepository) : IOdbErrorQueryService
{
    public async Task<OdbError?> Handle(GetOdbErrorByIdQuery query)
    {
        return await odbErrorRepository.FindByIdAsync(query.OdbErrorId);
    }

    public async Task<IEnumerable<OdbError>> Handle(GetAllOdbErrorsQuery query)
    {
        return await odbErrorRepository.ListAsync();
    }
}
