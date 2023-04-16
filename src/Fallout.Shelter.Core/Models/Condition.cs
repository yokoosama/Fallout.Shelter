using Fallout.Shelter.Core.Enums;

namespace Fallout.Shelter.Core.Models;

public class Condition
{
    public ResourceType? ShouldThrowResourceOfType { get; set; }
    public int? ShouldThrowResourceAmount { get; set; }
    public bool ShouldThrowItem { get; set; }
    public bool ShouldBuild { get; set; }
    public bool ShouldInjureDweller { get; set; }

    protected bool Equals(Condition other)
    {
        return ShouldThrowResourceOfType == other.ShouldThrowResourceOfType &&
               ShouldThrowResourceAmount == other.ShouldThrowResourceAmount &&
               ShouldThrowItem == other.ShouldThrowItem && ShouldBuild == other.ShouldBuild &&
               ShouldInjureDweller == other.ShouldInjureDweller;
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

        return Equals((Condition)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ShouldThrowResourceOfType, ShouldThrowResourceAmount, ShouldThrowItem, ShouldBuild,
            ShouldInjureDweller);
    }

    public static bool operator ==(Condition? left, Condition? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Condition? left, Condition? right)
    {
        return !Equals(left, right);
    }
}