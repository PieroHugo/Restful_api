// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;

public record FailureResource(int Id, string SuggestSolution, BadPracticeResource BadPractice, OdbErrorResource OdbError, string FailureStatus, string FailureType, string FailureUrgency);
