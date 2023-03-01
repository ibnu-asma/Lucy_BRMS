namespace Lucy_BRMS.Models;

public class Building{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public int NumberOfFloors { get; set; }

    public int NumberOfRooms { get; set; }

    public string Address { get; set; }

    public string ImageUrl { get; set; }
}