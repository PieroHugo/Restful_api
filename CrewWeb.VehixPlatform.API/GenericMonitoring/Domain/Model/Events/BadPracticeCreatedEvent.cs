// This module is generic. Customize it for your API needs.
using ACME.LearningCenterPlatform.API.Shared.Domain.Model.Events;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Events;

public class BadPracticeCreatedEvent(string descriptionBadPractice) : IEvent
{
    public string DescriptionbadPractice { get; } = descriptionBadPractice;
}