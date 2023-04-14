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
    public bool RoomPoolRefresh { get; set; }
    public bool ItemPoolRefresh { get; set; }
    public KeyValuePair<ResourceType, int>? ExchangeFrom { get; set; }
    public KeyValuePair<ResourceType, int>? ExchangeTo { get; set; }

    protected bool Equals(Reward other)
    {
        return ResourceType == other.ResourceType &&
               ResourceAmount == other.ResourceAmount &&
               Happiness == other.Happiness &&
               NewDweller == other.NewDweller &&
               FirstPlayerToken == other.FirstPlayerToken &&
               Build == other.Build &&
               SpecialStat == other.SpecialStat &&
               ResourceExchange == other.ResourceExchange &&
               HealDweller == other.HealDweller &&
               NewItem == other.NewItem &&
               ActivateItem == other.ActivateItem &&
               RoomPoolRefresh == other.RoomPoolRefresh &&
               ItemPoolRefresh == other.ItemPoolRefresh &&
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
        hashCode.Add(ResourceType);
        hashCode.Add(ResourceAmount);
        hashCode.Add(Happiness);
        hashCode.Add(NewDweller);
        hashCode.Add(FirstPlayerToken);
        hashCode.Add(Build);
        hashCode.Add(SpecialStat);
        hashCode.Add(ResourceExchange);
        hashCode.Add(HealDweller);
        hashCode.Add(NewItem);
        hashCode.Add(ActivateItem);
        hashCode.Add(RoomPoolRefresh);
        hashCode.Add(ItemPoolRefresh);
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