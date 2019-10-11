using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryServicePatternDemo.ViewComponents
{
    public class FinancialStatsViewComponent : ViewComponent
    {
        private readonly IFinancialsService _financialService;

        public FinancialStatsViewComponent(IFinancialsService financialService)
        {
            _financialService = financialService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var stats = _financialService.GetStats();
            return Task.FromResult<IViewComponentResult>(View(stats));
        }
    }
}
