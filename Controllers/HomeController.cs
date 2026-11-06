using Microsoft.AspNetCore.Mvc;

namespace WebAppMMS.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}