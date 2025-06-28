// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;

public record CreateOdbErrorCommand(string ErrorCode, string ErrorCodeTitle, string ErrorType);
