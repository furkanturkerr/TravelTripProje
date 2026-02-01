using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}