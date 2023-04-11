namespace Fallout.Shelter.Core.Models;

public class Building
{
    public Dictionary<CurrencyType, int> Price { get; set; }
    public bool IsElevator { get; set; }
    public Space[] Spaces { get; set; }

    public Building(Dictionary<CurrencyType, int> price)
    {
        Price = price;
        Spaces = new Space[2];
    }
}