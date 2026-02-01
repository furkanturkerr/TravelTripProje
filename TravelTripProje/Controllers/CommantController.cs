using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Context;

namespace TravelTripProje.Controllers;

public class CommantController : Controller
{
    private readonly TripContext _context;

    public CommantController(TripContext context)
    {
        _context = context;
    }

    // GET
    public IActionResult Index()
    {
        var value = _context.Commands.ToList();
        return View(value);
    }

    public IActionResult Delete(int id)
    {
        var value = _context.Commands.Find(id);
        _context.Commands.Remove(value);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}