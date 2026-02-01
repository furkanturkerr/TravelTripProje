using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Entities;

namespace TravelTripProje.Controllers;

public class UserController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public UserController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    // GET
    public IActionResult UserList()
    {
        var users = _userManager.Users.ToList();
        return View(users);
    }
}