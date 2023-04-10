namespace Fallout.Shelter.Core;

public class Building
{
    public Dictionary<ResourceType, int> Price { get; set; }
    public bool IsElevator { get; set; }
    public Space[] Spaces { get; set; }

    public Building(Dictionary<ResourceType, int> price)
    {
        Price = price;
        Spaces = new Space[2];
    }
}