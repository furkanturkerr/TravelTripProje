using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Context;

namespace TravelTripProje.ViewComponents.Home;

public class _HomePopulerBlogComponentPartial : ViewComponent
{
    private readonly TripContext _context;

    public _HomePopulerBlogComponentPartial(TripContext context)
    {
        _context = context;
    }
    public IViewComponentResult Invoke()
    {
        var value = _context.Blogs.Take(10).ToList();
        return View(value);
    }
}