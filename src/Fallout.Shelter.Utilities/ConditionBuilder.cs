using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public static class ConditionBuilder
{
    public static Condition BuildWithResources(CurrencyType type, int amount)
    {
        var condition = new Condition();
        condition.Resources.TryAdd(type, amount);

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