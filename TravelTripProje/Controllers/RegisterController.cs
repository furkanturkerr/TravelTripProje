using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Entities;
using TravelTripProje.Models;

namespace TravelTripProje.Controllers;

public class RegisterController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public RegisterController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    // GET
    public IActionResult CreateUser()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateUser(RegisterViewModel model)
    {
        AppUser appUser = new AppUser()
        {
            UserName = model.UserName,
            Email = model.Email
        };
        var result = await _userManager.CreateAsync(appUser, model.Password);
        if (result.Succeeded)
        {
            return RedirectToAction("UserList", "User");
        }
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
        }
        return View();
    }
}