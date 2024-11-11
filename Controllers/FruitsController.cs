using Microsoft.AspNetCore.Mvc;

namespace Lab9.Controllers
{
    public class FruitsController : Controller
    {
        public IActionResult FirstViewMethod()
        {
            return View(GetListOfFruits());
        }

        public IActionResult SecondViewMethod()
        {
            return View(GetListOfFruits().OrderBy(x => x).ToList());
        }
        public IActionResult ThirdViewMethod()
        {
            return View(GetListOfFruits().OrderBy(x => x).ToList());
        }


        private List<string> GetListOfFruits()
        {
            return new List<string> {
                "Apple",
                "Banana",
                "Orange",
                "Lemon",
                "Grape",
                "Plum",
                "Melon"
            };
        }
    }
}
