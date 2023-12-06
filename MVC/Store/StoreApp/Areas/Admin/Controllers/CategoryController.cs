using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]   // Area'lar kullanıldığında controller üstüne ifade edilmesi şart!!
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}