using HomeworkFishWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkFishWeb.Controllers
{
    public class FishController : Controller
    {
        //Fish fish = new Fish[]
        private static readonly Fish[] fish = new Fish[]
        {
            new Fish
            {
                Name = "GoldFish",
                Weight = "7g",
                Speed = "5km/h"
            },
            new Fish
            {
                Name = "Perch",
                Weight = "420g",
                Speed = "24km/h"
            },
            new Fish
            {
                Name = "Barracuda",
                Weight = "340g",
               Speed = "28km/h"
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataTransferByViewData()
        {
            ViewData["FishInformation"] = fish;
            return View();
        }

        public IActionResult DataTransferByViewBag()
        {
            ViewBag.FishInformation = fish;
            return View();
        }

        public IActionResult DataTransferByModel()
        {
            //ViewData["Carp"] = "Carp";
            //ViewBag.Ten = "10kg";
            return View(fish);
        }
    }
}
