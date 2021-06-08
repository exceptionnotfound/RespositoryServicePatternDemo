using RepositoryServicePatternDemo.Core.Models;
using System.Collections.Generic;

namespace RepositoryServicePatternDemo.Core.Services.Interfaces
{
    public interface ITicketService
    {
        List<Ticket> GetAllSold();
    }
}
