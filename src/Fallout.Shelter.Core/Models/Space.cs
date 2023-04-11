namespace Fallout.Shelter.Core.Models;

public class Space
{
    public List<Condition>? PriceToSpawn { get; set; }
    public List<Reward> Rewards { get; set; }
    public Dweller? Dweller { get; set; }
    public SpecialStat? SpecialStat { get; set; }

    public Space()
    {
        Rewards = new List<Reward>();
    }
}