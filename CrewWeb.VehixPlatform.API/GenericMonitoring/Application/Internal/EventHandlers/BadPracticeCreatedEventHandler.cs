// This module is generic. Customize it for your API needs.
using ACME.LearningCenterPlatform.API.Shared.Application.Internal.EventHandlers;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Events;
using Humanizer;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Application.Internal.EventHandlers;

public class BadPracticeCreatedEventHandler : IEventHandler<BadPracticeCreatedEvent>
{
    public Task Handle(BadPracticeCreatedEvent domainEvent, CancellationToken cancellationToken)
    {
        return On(domainEvent);
    }

    private Task On(BadPracticeCreatedEvent domainEvent)
    {
        Console.WriteLine("Created Bad Practice: {0}", domainEvent.DescriptionbadPractice);
        return Task.CompletedTask;
    }
}