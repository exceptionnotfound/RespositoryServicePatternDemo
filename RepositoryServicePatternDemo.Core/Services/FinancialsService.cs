using RepositoryServicePatternDemo.Core.Repositories.Interfaces;
using RepositoryServicePatternDemo.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryServicePatternDemo.Core.Services
{
    public class FinancialsService : IFinancialsService
    {
        private readonly ITicketRepository _ticketRepo;
        private readonly IFoodRepository _foodRepo;

        public FinancialsService(ITicketRepository ticketRepo,
                                 IFoodRepository foodRepo)
        {
            _ticketRepo = ticketRepo;
            _foodRepo = foodRepo;
        }

        public decimal GetTotalSold()
        {
            var foodSold = _foodRepo.GetAllSold().Sum(x => x.Profit);
            var ticketsSold = _ticketRepo.GetAllSold().Sum(x => x.Profit);

            return foodSold + ticketsSold;
        }
    }
}
