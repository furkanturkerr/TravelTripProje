using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.ViewComponents.Home;

public class _HomeThreeBlogComponentPartial : ViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View();
    }
}