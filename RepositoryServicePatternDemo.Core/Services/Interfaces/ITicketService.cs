using RepositoryServicePatternDemo.Core.Models;
using RepositoryServicePatternDemo.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryServicePatternDemo.Core.Services.Interfaces
{
    public interface ITicketService
    {
        List<Ticket> GetAllSold();
    }
}
