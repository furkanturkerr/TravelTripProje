using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Context;

namespace TravelTripProje.ViewComponents.Home;

public class _HomeSliderComponentPartial : ViewComponent
{
    private readonly TripContext _context;

    public _HomeSliderComponentPartial(TripContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var value = _context.Sliders.ToList();
        return View(value);
    }
}