// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;

public static class CreateBadPracticeCommandFromResourceAssembler
{
    public static CreateBadPracticeCommand ToCommandFromResource(CreateBadPracticeResource resource)
    {
        return new CreateBadPracticeCommand(resource.DescriptionBadPractice);
    }
}
