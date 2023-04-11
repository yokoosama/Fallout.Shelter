namespace Fallout.Shelter.Core.Models;

public class Room
{
    public string Name { get; set; }
    public Dictionary<ResourceType, int> Price { get; set; }
    public bool IsElevator { get; set; }
    public Space[] Spaces { get; set; }
    
    public Room(string name, bool isElevator = false)
    {
        Name = name;
        IsElevator = isElevator;
        Price = new Dictionary<ResourceType, int>();
        Spaces = new Space[isElevator ? 1 : 2];
    }
    
    public Room(string name, Dictionary<ResourceType, int> price)
    {
        Price = price;
        Name = name;
        Spaces = new Space[2];
    }
}