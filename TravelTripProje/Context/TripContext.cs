using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelTripProje.Entities;

namespace TravelTripProje.Context;

public class TripContext : IdentityDbContext<AppUser>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
         "Server=localhost,1995;Database=TravelTrip;User Id=sa;Password=Furkan12*;TrustServerCertificate=True;");
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Commant> Commands { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Home> Homes { get; set; }
    public DbSet<Slider>  Sliders { get; set; }
}