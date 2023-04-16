using Fallout.Shelter.Core.Enums;

namespace Fallout.Shelter.Core.Models;

public class Item
{
    public string Name { get; set; }
    public ItemType Type { get; set; }
    public bool IsActive { get; set; }
    public bool IsAlwaysActive { get; set; }
    public bool IsEndGameItem { get; set; }

    public bool GiveActivateItemPossibility { get; set; }
    public int? GiveAdditionalDamage { get; set; }
    public bool GiveReRollPossibility { get; set; }
    public bool HealDweller { get; set; }
    public SpecialStat? GiveSpecialStatToDweller { get; set; }
}