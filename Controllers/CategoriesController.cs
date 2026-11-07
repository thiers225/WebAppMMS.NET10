using Microsoft.AspNetCore.Mvc;
using WebAppMMS.Models;

namespace WebAppMMS.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: CategoriesController
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }
   public IActionResult Edit(int? id)
    {
        ViewBag.Action = "edit";
        var category = id.HasValue
            ? CategoriesRepository.GetCategoryById(id.Value)
            : new Category();

        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoriesRepository.UpdateCategory(category.CategoryId, category);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Action = "edit";

            return View(category);
        }

    public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View();
        }
    [HttpPost]
    public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoriesRepository.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Action = "add";

            return View(category);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int categoryId)
        {
            CategoriesRepository.DeleteCategory(categoryId);
            return RedirectToAction(nameof(Index));
        }

       

    }
}
