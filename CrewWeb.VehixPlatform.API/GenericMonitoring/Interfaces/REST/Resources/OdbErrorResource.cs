// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

public record OdbErrorResource(int Id, string ErrorCode, string ErrorTitle, string ErrorType);
