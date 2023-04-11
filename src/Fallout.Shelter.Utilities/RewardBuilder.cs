using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public static class RewardBuilder
{
    public static Reward BuildWithResources(ResourceType type, int amount)
    {
        var reward = new Reward
        {
            ResourceType = type,
            ResourceAmount = amount
        };

        return reward;
    }

    public static Reward BuildWithItem()
    {
        var reward = new Reward
        {
            ItemGain = true
        };

        return reward;
    }

    public static Reward BuildWithItemPoolRefresh()
    {
        var reward = new Reward
        {
            ItemPoolRefresh = true
        };

        return reward;
    }

    public static Reward BuildWithFirstPlayerToken()
    {
        var reward = new Reward
        {
            IsFirstPlayerTokenGain = true
        };

        return reward;
    }

    public static Reward BuildWithSpecialStat(SpecialStat stat)
    {
        var reward = new Reward
        {
            SpecialStat = stat
        };

        return reward;
    }
    
    public static Reward BuildWithDweller()
    {
        var reward = new Reward
        {
            IsDwellerGain = true
        };

        return reward;
    }
}