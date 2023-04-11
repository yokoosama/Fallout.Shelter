namespace Fallout.Shelter.Core.Models;

public class Building
{
    public string Name { get; set; }
    public Dictionary<ResourceType, int> Price { get; set; }
    public bool IsElevator { get; set; }
    public Space[] Spaces { get; set; }
    
    public Building(string name, bool isElevator = false)
    {
        Name = name;
        IsElevator = isElevator;
        Price = new Dictionary<ResourceType, int>();
        Spaces = new Space[isElevator ? 1 : 2];
    }
    
    public Building(string name, Dictionary<ResourceType, int> price)
    {
        Price = price;
        Name = name;
        Spaces = new Space[2];
    }
}