// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Queries;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;

public interface IBadPracticeQueryService
{
    Task<BadPractice?> Handle(GetBadPracticeByIdQuery query);
    Task<IEnumerable<BadPractice>> Handle(GetAllBadPracticesQuery query);
}
