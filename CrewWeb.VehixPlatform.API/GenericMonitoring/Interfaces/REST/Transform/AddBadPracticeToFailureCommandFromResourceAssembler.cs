// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;

public static class AddBadPracticeToFailureCommandFromResourceAssembler
{
    public static AddBadPracticeToFailureCommand ToCommandFromResource(AddBadPracticeToFailureResource resource, int failureId)
    {
        return new AddBadPracticeToFailureCommand(resource.DescriptionBadPractice, failureId);
    }
}