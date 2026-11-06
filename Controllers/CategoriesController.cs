using Microsoft.AspNetCore.Mvc;
using WebAppMMS.Models;

namespace WebAppMMS.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View();
        }
    public IActionResult Edit(int? id)
    {
        var category = new Category
        {
            CategoryId = id ?? 0
        };

        return View(category);
    }
       

    }
}
