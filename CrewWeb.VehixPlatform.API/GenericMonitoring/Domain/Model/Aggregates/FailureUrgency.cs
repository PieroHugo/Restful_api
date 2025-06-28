// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.ValueObjects;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;

public partial class Failure : IUrgency
{
    public EFailureUrgency Urgency { get; protected set; }
    
    public void ChangeToCritical()
    {
        Urgency = EFailureUrgency.Critical;
    }

    public void ChangeToModerate()
    {
        Urgency = EFailureUrgency.Moderate;
    }

    public void ChangeToMild()
    {
        Urgency = EFailureUrgency.Mild;
    }
}