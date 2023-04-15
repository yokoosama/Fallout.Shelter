namespace Fallout.Shelter.Core.Models;

public class Condition
{
    public ResourceType? ResourceType { get; set; }
    public int? ResourceAmount { get; set; }
    public bool Item { get; set; }
    public bool Build { get; set; }
    public bool InjureDweller { get; set; }
    public int? Roll { get; set; }

    protected bool Equals(Condition other)
    {
        return ResourceType == other.ResourceType &&
               ResourceAmount == other.ResourceAmount && 
               Item == other.Item && Build == other.Build && 
               InjureDweller == other.InjureDweller && 
               Roll == other.Roll;
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

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((Condition)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ResourceType, ResourceAmount, Item, Build, InjureDweller, Roll);
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