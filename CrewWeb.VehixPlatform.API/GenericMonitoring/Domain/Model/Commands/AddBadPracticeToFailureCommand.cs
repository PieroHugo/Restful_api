// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;

public record AddBadPracticeToFailureCommand(string DescriptionBadPractice, int FailureId);
