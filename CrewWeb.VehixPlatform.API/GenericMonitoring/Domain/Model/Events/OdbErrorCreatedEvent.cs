// This module is generic. Customize it for your API needs.
using ACME.LearningCenterPlatform.API.Shared.Domain.Model.Events;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Events;

public class OdbErrorCreatedEvent(string errorCode, string errorCodeTitle) : IEvent
{
    public string ErrorCode { get; } = errorCode;
    public string ErrorCodeTitle { get; } = errorCodeTitle;
}