using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Context;
using TravelTripProje.Entities;

namespace TravelTripProje.Controllers;

public class BlogController : Controller
{
    private readonly TripContext _context;

    public BlogController(TripContext context)
    {
        _context = context;
    }

    // GET
    public IActionResult BlogList()
    {
        var value = _context.Blogs.ToList();
        return View(value);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Blog blog)
    {
        _context.Add(blog);
        _context.SaveChanges();
        return RedirectToAction("BlogList");
    }

    public IActionResult Update(int id)
    {
        var value = _context.Blogs.Find(id);
        return View(value);
    }

    [HttpPost]
    public IActionResult Update(Blog blog)
    {
        _context.Update(blog);
        _context.SaveChanges();
        return RedirectToAction("BlogList");
    }

    public IActionResult Delete(int id)
    {
        var value = _context.Blogs.Find(id);
        _context.Blogs.Remove(value);
        _context.SaveChanges();
        return RedirectToAction("BlogList");
    }
}