namespace Fallout.Shelter.Core.Models;

public class Condition
{
    public Dictionary<CurrencyType, int> Resources { get; set; }
    public int Happiness { get; set; }
    public bool IsItemNeeded { get; set; }
    public bool ShouldDwellerBeInjured { get; set; }
    public bool InjureDweller { get; set; }
    public bool ShouldBuild { get; set; }
    public int Roll { get; set; }

    public Condition()
    {
        Resources = new Dictionary<CurrencyType, int>(4);
    }
}