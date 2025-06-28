// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

public record AddOdbErrorToFailureResource(string ErrorCode, string ErrorCodeTitle, string ErrorType);
