// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Queries;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Repositories;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Application.Internal.QueryServices;

public class BadPracticeQueryService(IBadPracticeRepository badPracticeRepository) : IBadPracticeQueryService
{
    public async Task<BadPractice?> Handle(GetBadPracticeByIdQuery query)
    {
        return await badPracticeRepository.FindByIdAsync(query.BadPracticeId);
    }

    public async Task<IEnumerable<BadPractice>> Handle(GetAllBadPracticesQuery query)
    {
        return await badPracticeRepository.ListAsync();
    }
}