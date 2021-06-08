using RepositoryServicePatternDemo.Core.Models;

namespace RepositoryServicePatternDemo.Core.Services.Interfaces
{
    public interface IFinancialsService
    {
        decimal GetTotalSold();
        FinancialStats GetStats();
    }
}
