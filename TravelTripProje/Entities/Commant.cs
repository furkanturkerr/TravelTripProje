namespace TravelTripProje.Entities;

public class Commant
{
    public int CommantId { get; set; }
    public string UserName { get; set; }
    public string Mail { get; set; }
    public string CommantText { get; set; }
    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}