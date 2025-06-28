// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.ValueObjects;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;

public partial class Failure : IState
{
    public EFailureStatus Status { get; protected set; }
    
    public void ChangeToFixed()
    {
        Status = EFailureStatus.Fixed;
    }

    public void ChangeToPending()
    {
        Status = EFailureStatus.Pending;
    }
}