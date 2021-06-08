using RepositoryServicePatternDemo.Core.Models;
using RepositoryServicePatternDemo.Core.Repositories.Interfaces;
using System.Collections.Generic;

namespace RepositoryServicePatternDemo.Core.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        public List<Ticket> GetAllSold()
        {
            List<Ticket> tickets = new List<Ticket>()
            {
                new Ticket()
                {
                    ID = 1953772,
                    MovieName = "Joker",
                    SalePrice = 8.99M,
                    StudioCutPercentage = 0.75M,
                    Quantity = 419
                },
                new Ticket()
                {
                    ID = 2817721,
                    MovieName = "Toy Story 4",
                    SalePrice = 7.99M,
                    StudioCutPercentage = 0.9M,
                    Quantity = 112
                },
                new Ticket()
                {
                    ID = 2177492,
                    MovieName = "Hustlers",
                    SalePrice = 8.49M,
                    StudioCutPercentage = 0.67M,
                    Quantity = 51
                },
                new Ticket()
                {
                    ID = 2747119,
                    MovieName = "Downton Abbey",
                    SalePrice = 8.99M,
                    StudioCutPercentage = 0.72M,
                    Quantity = 214
                }
            };

            return tickets;
        }
    }
}
