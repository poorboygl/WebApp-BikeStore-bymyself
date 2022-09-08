using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Areas.Dashboard.Controllers
{
    [Area("dashboard")]
    public class CoronaController : Controller
    {

        SiteProvider provider;

        public CoronaController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<string> GetCoronas()
        {
            return await provider.Corona.GetCoronas();
        }
    }
}
