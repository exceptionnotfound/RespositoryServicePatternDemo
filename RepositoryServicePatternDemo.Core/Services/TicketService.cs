using RepositoryServicePatternDemo.Core.Models;
using RepositoryServicePatternDemo.Core.Repositories.Interfaces;
using RepositoryServicePatternDemo.Core.Services.Interfaces;
using System.Collections.Generic;

namespace RepositoryServicePatternDemo.Core.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepo;

        public TicketService(ITicketRepository ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }

        public List<Ticket> GetAllSold() => _ticketRepo.GetAllSold();
    }
}
