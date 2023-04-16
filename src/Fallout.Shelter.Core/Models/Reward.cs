using Fallout.Shelter.Core.Enums;

namespace Fallout.Shelter.Core.Models;

public class Reward
{
    public ResourceType? GiveResourceOfType { get; set; }
    public int? GiveResourceAmount { get; set; }
    public int? GiveHappiness { get; set; }
    public bool GiveNewDweller { get; set; }
    public bool GiveFirstPlayerToken { get; set; }
    public bool GiveBuildPossibility { get; set; }
    public SpecialStat? GiveSpecialStatToDweller { get; set; }
    public bool GiveResourceExchangePossibility { get; set; }
    public bool HealDweller { get; set; }
    public bool GiveNewItem { get; set; }
    public bool GiveActivateItemPossibility { get; set; }
    public bool GiveRoomPoolRefreshPossibility { get; set; }
    public bool GiveItemPoolRefreshPossibility { get; set; }
    public KeyValuePair<ResourceType, int>? ExchangeFrom { get; set; }
    public KeyValuePair<ResourceType, int>? ExchangeTo { get; set; }

    protected bool Equals(Reward other)
    {
        return GiveResourceOfType == other.GiveResourceOfType &&
               GiveResourceAmount == other.GiveResourceAmount &&
               GiveHappiness == other.GiveHappiness &&
               GiveNewDweller == other.GiveNewDweller &&
               GiveFirstPlayerToken == other.GiveFirstPlayerToken &&
               GiveBuildPossibility == other.GiveBuildPossibility &&
               GiveSpecialStatToDweller == other.GiveSpecialStatToDweller &&
               GiveResourceExchangePossibility == other.GiveResourceExchangePossibility &&
               HealDweller == other.HealDweller &&
               GiveNewItem == other.GiveNewItem &&
               GiveActivateItemPossibility == other.GiveActivateItemPossibility &&
               GiveRoomPoolRefreshPossibility == other.GiveRoomPoolRefreshPossibility &&
               GiveItemPoolRefreshPossibility == other.GiveItemPoolRefreshPossibility &&
               Nullable.Equals(ExchangeFrom, other.ExchangeFrom) &&
               Nullable.Equals(ExchangeTo, other.ExchangeTo);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((Reward)obj);
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(GiveResourceOfType);
        hashCode.Add(GiveResourceAmount);
        hashCode.Add(GiveHappiness);
        hashCode.Add(GiveNewDweller);
        hashCode.Add(GiveFirstPlayerToken);
        hashCode.Add(GiveBuildPossibility);
        hashCode.Add(GiveSpecialStatToDweller);
        hashCode.Add(GiveResourceExchangePossibility);
        hashCode.Add(HealDweller);
        hashCode.Add(GiveNewItem);
        hashCode.Add(GiveActivateItemPossibility);
        hashCode.Add(GiveRoomPoolRefreshPossibility);
        hashCode.Add(GiveItemPoolRefreshPossibility);
        hashCode.Add(ExchangeFrom);
        hashCode.Add(ExchangeTo);

        return hashCode.ToHashCode();
    }

    public static bool operator ==(Reward? left, Reward? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Reward? left, Reward? right)
    {
        return !Equals(left, right);
    }
}