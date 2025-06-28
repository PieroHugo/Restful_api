// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.ValueObjects;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;

public partial class Failure : IType
{
    public EFailureType Type { get; protected set; }

    public void ChangeToSimple()
    {
        Type = EFailureType.Simple;
    }

    public void ChangeToTechnical()
    {
        Type = EFailureType.Technical;
    }

    public void ChangeToBadPractice()
    {
        Type = EFailureType.BadPractice;
    }
}