using Microsoft.AspNetCore.Mvc;

namespace DotNetProject.Controllers;

public class CompanyController : Controller
{

    public IActionResult Index()
    {

        return View();
    }
}
