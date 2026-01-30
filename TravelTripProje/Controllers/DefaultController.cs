using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}