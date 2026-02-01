using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelTripProje.Context;
using TravelTripProje.Entities;
using TravelTripProje.Models;

namespace TravelTripProje.Controllers;
[AllowAnonymous]
public class DefaultController : Controller
{
    private readonly TripContext _tripContext;

    public DefaultController(TripContext tripContext)
    {
        _tripContext = tripContext;
    }

    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        var value = _tripContext.Abouts.FirstOrDefault();
        return View(value);
    }

    public IActionResult Blog()
    {
        var value = _tripContext.Blogs.OrderByDescending(x=>x.Date).ToList();
        return View(value);
    }

    public IActionResult BlogDetail(int id)
    {
        var value = _tripContext.Blogs.Include(x=>x.Commant).FirstOrDefault(y=>y.BlogId == id);

        var lastBlog = _tripContext.Blogs.Take(5).ToList();

        var model = new BlogDetailModel()
        {
            Blog = value,
            Commant = value.Commant,
            LastBlog = lastBlog
        };
        
        return View(model);
    }

    [HttpPost]
    public IActionResult BlogComment(Commant comment)
    {
        _tripContext.Commands.Add(comment);
        _tripContext.SaveChanges();
        return RedirectToAction("BlogDetail", new { id = comment.BlogId });
    }
}