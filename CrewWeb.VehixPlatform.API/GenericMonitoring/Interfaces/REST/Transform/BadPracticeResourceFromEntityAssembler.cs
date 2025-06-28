// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;

public static class BadPracticeResourceFromEntityAssembler
{
    public static BadPracticeResource ToResourceFromEntity(BadPractice badPractice)
    {
        return new BadPracticeResource(badPractice.Id, badPractice.DescriptionBadPractice);
    }
}
