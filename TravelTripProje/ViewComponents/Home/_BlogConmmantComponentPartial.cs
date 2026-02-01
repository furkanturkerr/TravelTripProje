using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Context;

namespace TravelTripProje.ViewComponents.Home;

public class _BlogConmmantComponentPartial : ViewComponent
{
    private readonly TripContext _context;

    public _BlogConmmantComponentPartial(TripContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke(int blogid)
    {
        ViewBag.blogId = blogid;
        return View();
    }
}