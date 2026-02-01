namespace TravelTripProje.Entities;

public class Blog
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string BlogImage { get; set; }
    
    public List<Commant>  Commant { get; set; }
}