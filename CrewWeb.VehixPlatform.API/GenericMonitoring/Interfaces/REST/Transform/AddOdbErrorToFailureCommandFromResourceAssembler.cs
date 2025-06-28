// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;

public static class AddOdbErrorToFailureCommandFromResourceAssembler
{
    public static AddOdbErrorToFailureCommand ToCommandFromResource(AddOdbErrorToFailureResource resource,
        int failureId)
    {
        return new AddOdbErrorToFailureCommand(resource.ErrorCode, resource.ErrorCodeTitle, resource.ErrorType,failureId);
    }
}