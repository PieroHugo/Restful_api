// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.ValueObjects;

public interface IUrgency
{
    void ChangeToCritical();
    void ChangeToModerate();
    void ChangeToMild();
}
