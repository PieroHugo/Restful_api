// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Entities;

public class BadPractice(string descriptionBadPractice)
{
    public int Id { get; set; }
    public string DescriptionBadPractice { get; set; } = descriptionBadPractice;
    
    
    public BadPractice() : this(string.Empty)
    {
    }

    public BadPractice(CreateBadPracticeCommand command) : this(command.DescriptionBadPractice)
    {
    }
    
}