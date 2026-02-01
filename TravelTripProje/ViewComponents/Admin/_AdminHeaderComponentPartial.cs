using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.ViewComponents.Admin;

public class _AdminHeaderComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}