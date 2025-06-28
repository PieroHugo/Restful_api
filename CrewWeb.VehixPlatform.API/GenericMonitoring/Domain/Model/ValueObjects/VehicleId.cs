// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.ValueObjects;

/// <summary>
/// Represents a unique identifier for a vehicle.
/// </summary>
/// <param name="Id">
/// The unique identifier for the vehicle.
/// </param>
public record VehicleId(int Id);
