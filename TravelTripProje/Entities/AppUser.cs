using Microsoft.AspNetCore.Identity;

namespace TravelTripProje.Entities;

public class AppUser : IdentityUser
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
}