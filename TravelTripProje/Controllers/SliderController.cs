using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Context;

namespace TravelTripProje.Controllers;

public class SliderController : Controller
{
    private readonly TripContext _context;

    public SliderController(TripContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var value = _context.Sliders.ToList();
        return View(value);
    }
}