// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;
using Microsoft.OpenApi.Extensions;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;

public static class FailureResourceFromEntityAssembler
{
    public  static FailureResource ToResourceFromEntity(Failure entity)
    {
        return new FailureResource(
            entity.Id,
            entity.SuggestSolution,
            BadPracticeResourceFromEntityAssembler.ToResourceFromEntity(entity.BadPractice),
            OdbErrorResourceFromEntityAssembler.ToResourceFromEntity(entity.OdbError),
            entity.Status.GetDisplayName(),
            entity.Type.GetDisplayName(),
            entity.Urgency.GetDisplayName()
        );
    }
    
}