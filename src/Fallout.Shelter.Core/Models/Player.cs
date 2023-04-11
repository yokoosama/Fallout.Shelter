namespace Fallout.Shelter.Core.Models;

public class Player
{
    public int Id { get; set; }
    public bool IsFirstPlayer { get; set; }
    public Dictionary<CurrencyType, int> Resources { get; set; }
    public int Happiness { get; set; }
    public List<Dweller> Dwellers { get; set; }

    public Player()
    {
        Dwellers = new List<Dweller>(7)
        {
            new(),
            new()
        };

        Resources = new Dictionary<CurrencyType, int>(3)
        {
            { CurrencyType.Water, 0 },
            { CurrencyType.Food, 0 },
            { CurrencyType.Energy, 0 }
        };
    }
}