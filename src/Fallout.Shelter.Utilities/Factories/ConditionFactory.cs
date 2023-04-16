using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public static class ConditionFactory
{
    public static Condition CreateWithResources(ResourceType type, int amount)
    {
        var condition = new Condition
        {
            ShouldThrowResourceOfType = type,
            ShouldThrowResourceAmount = amount
        };

        return condition;
    }

    public static Condition CreateWithInjuredDweller()
    {
        var condition = new Condition
        {
            ShouldInjureDweller = true
        };

        return condition;
    }

    public static Condition CreateWithItem()
    {
        var condition = new Condition
        {
            ShouldThrowItem = true
        };

        return condition;
    }

    public static Condition CreateWithBuild()
    {
        var condition = new Condition
        {
            ShouldBuild = true
        };

        return condition;
    }
}