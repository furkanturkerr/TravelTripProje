using TravelTripProje.Entities;

namespace TravelTripProje.Models;

public class BlogDetailModel
{
    public Blog Blog { get; set; }
    public List<Commant>  Commant { get; set; }
    public List<Blog> LastBlog { get; set; }
}