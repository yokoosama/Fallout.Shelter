namespace Fallout.Shelter.Core;

public class Condition
{
    public Dictionary<ResourceType, int> Resources { get; set; }
    public int Happiness { get; set; }
    public bool IsItemNeeded { get; set; }
    public bool ShouldDwellerBeInjured { get; set; }
    public bool InjureDweller { get; set; }
    public bool ShouldBuild { get; set; }
    public int Roll { get; set; }

    public Condition()
    {
        Resources = new Dictionary<ResourceType, int>(4);
    }
}