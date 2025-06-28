// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.ValueObjects;

/// <summary>
/// Represents the urgency level of a failure.
/// </summary>
public enum EFailureUrgency
{
    /// <summary>
    /// Represents a critical failure that requires immediate attention.
    /// </summary>
    Critical,
    
    /// <summary>
    /// Represents a medium urgency failure that should be addressed promptly.
    /// </summary>
    Moderate,
    
    /// <summary>
    /// Represents a minor failure that may be resolved soon
    /// </summary>
    Mild
}