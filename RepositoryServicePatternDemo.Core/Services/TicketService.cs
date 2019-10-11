using RepositoryServicePatternDemo.Core.Repositories;
using RepositoryServicePatternDemo.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryServicePatternDemo.Core.Services
{
    public class TicketService : TicketRepository, ITicketService { }
}
