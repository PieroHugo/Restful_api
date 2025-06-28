// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;
using Microsoft.OpenApi.Extensions;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;

public static class OdbErrorResourceFromEntityAssembler
{
    public static OdbErrorResource ToResourceFromEntity(OdbError odbError)
    {
        return new OdbErrorResource(odbError.Id, odbError.ErrorCode, odbError.ErrorCodeTitle, odbError.ErrorTypeString);
    }
}