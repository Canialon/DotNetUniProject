using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class RandomNumberController : Controller
    {
        public IActionResult Index()   
        {
            // Generate rundom number from 0 to 100
            Random random = new Random();
            int randomNumber = random.Next(101);

            ViewBag.RandomNumber = randomNumber;

            return View();
        }
    }
}