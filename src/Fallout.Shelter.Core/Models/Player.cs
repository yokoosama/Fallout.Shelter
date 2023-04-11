namespace Fallout.Shelter.Core.Models;

public class Player
{
    public int Id { get; set; }
    public bool IsFirstPlayer { get; set; }
    public Dictionary<ResourceType, int> Resources { get; set; }
    public int Happiness { get; set; }
    public Dweller[] Dwellers { get; set; }

    public Player()
    {
        Dwellers = new Dweller[7];
        Dwellers[0] = new Dweller();
        Dwellers[1] = new Dweller();

        Resources = new Dictionary<ResourceType, int>(3)
        {
            { ResourceType.Water, 0 },
            { ResourceType.Food, 0 },
            { ResourceType.Energy, 0 }
        };
    }
}