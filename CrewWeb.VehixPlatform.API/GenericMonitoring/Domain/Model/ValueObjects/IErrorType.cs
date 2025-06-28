// This module is generic. Customize it for your API needs.
namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.ValueObjects;

public interface IErrorType
{
    
    void SendToPowertrain();

    void SendToChassis();
    
    void SendToBody();
    
    void SendToNetwork();
    
}