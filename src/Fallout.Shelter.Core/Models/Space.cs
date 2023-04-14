namespace Fallout.Shelter.Core.Models;

public class Space
{
    public Dweller? Dweller { get; set; }
    public bool IsOnlyForInjuredDweller { get; set; }
    public SpecialStat? SpecialStat { get; set; }
}