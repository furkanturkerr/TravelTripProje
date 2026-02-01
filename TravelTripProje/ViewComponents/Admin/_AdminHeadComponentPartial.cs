using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.ViewComponents.Admin;

public class _AdminHeadComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}