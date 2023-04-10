namespace Fallout.Shelter.Core;

public class Player
{
    public int Id { get; set; }
    public bool IsFirstPlayer { get; set; }
    public Dictionary<ResourceType, int> Resources { get; set; }
    public int Happiness { get; set; }
    public List<Dweller> Dwellers { get; set; }

    public Player()
    {
        Dwellers = new List<Dweller>(7)
        {
            new (),
            new ()
        };

        Resources = new Dictionary<ResourceType, int>(3)
        {
            { ResourceType.Water, 0 },
            { ResourceType.Food, 0 },
            { ResourceType.Energy, 0 }
        };
    }
}