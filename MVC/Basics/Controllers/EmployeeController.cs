using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello world. {DateTime.Now.ToString()}";
            return View("Index1",message);
        }

        public ViewResult Index2()
        {
            var names = new string[]{
                "Ahmet", "Mehmet", "Can"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){ID=1, FirstName="Ahmet", LastName="Can", Age=20},
                new Employee(){ID=2, FirstName="Can", LastName="Dağ", Age=25},
                new Employee(){ID=3, FirstName="Demir", LastName="Güneş", Age=37}
            };
            return View("Index3",list);
        }

    }
}