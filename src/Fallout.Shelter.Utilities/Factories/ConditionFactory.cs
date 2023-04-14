using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public static class ConditionFactory
{
    public static Condition CreateWithResources(ResourceType type, int amount)
    {
        var condition = new Condition
        {
            ResourceType = type,
            ResourceAmount = amount
        };

        return condition;
    }

    public static Condition CreateWithInjuredDweller()
    {
        var condition = new Condition
        {
            InjureDweller = true
        };

        return condition;
    }

    public static Condition CreateWithItem()
    {
        var condition = new Condition
        {
            Item = true
        };

        return condition;
    }

    public static Condition CreateWithBuild()
    {
        var condition = new Condition
        {
            Build = true
        };

        return condition;
    }
}