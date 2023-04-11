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
    public KeyValuePair<ResourceType, int> ExchangeFrom { get; set; }
    public KeyValuePair<ResourceType, int> ExchangeTo { get; set; }
    public ResourceType ResourceType { get; set; }
    public int ResourceAmount { get; set; }
}