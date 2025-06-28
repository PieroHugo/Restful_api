// This module is generic. Customize it for your API needs.
using ACME.LearningCenterPlatform.API.Shared.Application.Internal.EventHandlers;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Events;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Application.Internal.EventHandlers;

public class OdbErrorCreatedEventHandler : IEventHandler<OdbErrorCreatedEvent>
{
    public Task Handle(OdbErrorCreatedEvent domainEvent, CancellationToken cancellationToken)
    {
        return On(domainEvent);
    }

    private Task On(OdbErrorCreatedEvent domainEvent)
    {
        Console.WriteLine("Created ODB Error Code: {0}", domainEvent.ErrorCode);
        Console.WriteLine("Created ODB Error Title: {0}", domainEvent.ErrorCodeTitle);

        return Task.CompletedTask;
    }
}