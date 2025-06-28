// This module is generic. Customize it for your API needs.
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.Shared.Domain.Repositories;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Repositories;

public interface IFailureRepository : IBaseRepository<Failure>
{
    Task<IEnumerable<Failure>> FindByErrorType(string errorType);
    
    Task<IEnumerable<Failure>> FindBySuggestSolution(string suggestSolution);
    
    Task<IEnumerable<Failure>> FindByStatus(string status);
    
    Task<IEnumerable<Failure>> FindByType(string type);

    
    
}