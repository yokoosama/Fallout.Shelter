using Fallout.Shelter.Core.Enums;

namespace Fallout.Shelter.Core.Models;

public class Resource
{
    public ResourceType Type { get; set; }
    public int Amount { get; set; }

    public Resource(ResourceType type, int amount)
    {
        Type = type;
        Amount = amount;
    }

    protected bool Equals(Resource other)
    {
        return Type == other.Type && Amount == other.Amount;
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

        return Equals((Resource)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine((int)Type, Amount);
    }

    public static bool operator ==(Resource? left, Resource? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Resource? left, Resource? right)
    {
        return !Equals(left, right);
    }
}