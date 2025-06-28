// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;

public interface IBadPracticeCommandService
{
    public Task<BadPractice?> Handle(CreateBadPracticeCommand command);
}
