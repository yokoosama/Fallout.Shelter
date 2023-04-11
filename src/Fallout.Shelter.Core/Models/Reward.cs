namespace Fallout.Shelter.Core.Models;

public class Reward
{
    public ResourceType? ResourceType { get; set; }
    public int? ResourceAmount { get; set; }
    public int? Happiness { get; set; }
    public bool NewDweller { get; set; }
    public bool FirstPlayerToken { get; set; }
    public bool Build { get; set; }
    public SpecialStat? SpecialStat { get; set; }
    public bool ResourceExchange { get; set; }
    
    public bool HealDweller { get; set; }
    public bool NewItem { get; set; }
    public bool ActivateItem { get; set; }
    public bool BuildingPoolRefresh { get; set; }
    public bool ItemPoolRefresh { get; set; }
    public KeyValuePair<ResourceType, int>? ExchangeFrom { get; set; }
    public KeyValuePair<ResourceType, int>? ExchangeTo { get; set; }
    
}