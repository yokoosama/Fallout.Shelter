namespace Fallout.Shelter.Core.Models;

public class Condition
{
    public ResourceType ResourceType { get; set; }
    public int ResourceAmount { get; set; }
    public int Happiness { get; set; }
    public bool IsItemNeeded { get; set; }
    public bool ShouldDwellerBeInjured { get; set; }
    public bool ShouldDwellerBeHealed { get; set; }
    public bool ShouldBuild { get; set; }
    public int Roll { get; set; }
}