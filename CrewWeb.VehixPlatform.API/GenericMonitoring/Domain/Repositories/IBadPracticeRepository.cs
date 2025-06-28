// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;
using CrewWeb.VehixPlatform.API.Shared.Domain.Repositories;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Repositories;

public interface IBadPracticeRepository : IBaseRepository<BadPractice>
{

}
