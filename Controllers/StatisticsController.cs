namespace TenXOne.Controllers
{
    public class StatisticsController : Controller {
        public IActionResult Index()
        {
            var viewModel = new StatisticsViewModel();
            return View(viewModel);
        }
    }
}
