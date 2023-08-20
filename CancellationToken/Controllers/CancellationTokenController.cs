using Microsoft.AspNetCore.Mvc;

namespace CancellationToken.Controllers
{
    public class CancellationTokenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
