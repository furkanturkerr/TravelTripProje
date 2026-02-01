using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.ViewComponents.Admin;

public class _AdminSidebarComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}