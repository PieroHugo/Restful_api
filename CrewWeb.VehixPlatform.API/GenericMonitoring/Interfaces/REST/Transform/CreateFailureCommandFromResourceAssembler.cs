// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;

public static class CreateFailureCommandFromResourceAssembler
{
    public static CreateFailureCommand ToCommandFromResource(CreateFailureResource resource)
    {
        return new CreateFailureCommand(resource.ObdErrorId, resource.BadPracticeId, resource.SuggestSolution);
    }
}
