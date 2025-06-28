// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;

public static class CreateOdbErrorCommandFromResourceAssembler
{
    public static CreateOdbErrorCommand ToCommandFromResource(CreateOdbErrorResource resource)
    {
        return new CreateOdbErrorCommand(resource.ErrorCode, resource.ErrorCodeTitle, resource.ErrorType);
    }
}
