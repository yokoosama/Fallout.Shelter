namespace Fallout.Shelter.Core;

public class Dweller
{
    public int OwnerId { get; set; }
    public bool IsPlaced { get; set; }
    public bool IsInjured { get; set; }
    public SpecialStat? Special { get; set; }
}