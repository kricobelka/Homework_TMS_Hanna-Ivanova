using Microsoft.AspNetCore.Mvc;
using WebApplicationDogHW14.Models;

namespace WebApplicationDogHW14.Controllers
{
    public class DogController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult VetApplication ()
        {
            ModelState.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult VetApplication (DogViewModel dogViewModel)
        {
            System.Console.WriteLine($"Name of the dog: {dogViewModel.NameOfDog}, " +
                $"owner of the dog: {dogViewModel.NameOfOwner}, age of the dog: {dogViewModel.AgeOfDog}," +
                $"weight of the dog: {dogViewModel.WeightOfDog}.");
            return VetApplication();
        }


    }
}
