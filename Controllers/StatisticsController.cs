using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TenXOne.Models;
using TenXOne.Services;
using TenXOne.ViewModels;

namespace TenXOne.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }
        public IActionResult Index()
        {
            var viewModel = new StatisticsViewModel();
            viewModel.StatisticItems = new List<StatisticItem>();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Show() {
            var viewModel = new StatisticsViewModel();
            viewModel.StatisticItems = _statisticsService.GetAllStatisticItems();
            return PartialView( "_StatisticItemsListPartial", viewModel);
        }
    }
}
