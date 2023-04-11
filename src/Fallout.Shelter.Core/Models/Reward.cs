namespace Fallout.Shelter.Core.Models;

public class Reward
{
    public int Happiness { get; set; }
    public bool IsFirstPlayerTokenGain { get; set; }
    public bool IsDwellerGain { get; set; }
    public bool IsBuildingGain { get; set; }
    public SpecialStat? SpecialStat { get; set; }
    public bool HealDweller { get; set; }
    public bool ItemGain { get; set; }
    public bool ItemRefresh { get; set; }
    public bool BuildingPoolRefresh { get; set; }
    public bool ItemPoolRefresh { get; set; }
    public KeyValuePair<CurrencyType, int> ExchangeFrom { get; set; }
    public KeyValuePair<CurrencyType, int> ExchangeTo { get; set; }
    public Dictionary<CurrencyType, int> Resources { get; set; }

    public Reward()
    {
        Resources = new Dictionary<CurrencyType, int>();
    }
}