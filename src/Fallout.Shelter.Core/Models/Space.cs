namespace Fallout.Shelter.Core.Models;

public class Space
{
    public List<Condition> PriceToSpawn { get; set; }
    public List<Reward> Rewards { get; set; }
    public Dweller? Dweller { get; set; }
    public bool IsOnlyForInjuredDweller { get; set; }
    public SpecialStat? SpecialStat { get; set; }

    public Space()
    {
        PriceToSpawn = new List<Condition>();
        Rewards = new List<Reward>();
    }
}