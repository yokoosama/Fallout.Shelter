namespace Fallout.Shelter.Core;

public class Space
{
    public Condition? PriceToSpawn { get; set; }
    public Reward Reward { get; set; }
    public Dweller? Dweller { get; set; }
    public SpecialStat? SpecialStat { get; set; }
    
    public Space()
    {
        Reward = new Reward();
    }
}