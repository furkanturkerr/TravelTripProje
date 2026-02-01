using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Context;

namespace TravelTripProje.ViewComponents.Home;

public class _HomeLikeComponentPartial : ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
}