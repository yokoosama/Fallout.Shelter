using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public static class ConditionBuilder
{
    public static Condition BuildWithResources(ResourceType type, int amount)
    {
        var condition = new Condition
        {
            ResourceType = type,
            ResourceAmount = amount
        };

        return condition;
    }
    
    public static Condition BuildWithInjuredDweller()
    {
        var condition = new Condition
        {
            ShouldDwellerBeInjured = true
        };

        return condition;
    }
}