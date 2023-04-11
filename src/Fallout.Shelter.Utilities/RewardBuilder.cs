using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public static class RewardBuilder
{
    public static Reward BuildWithResources(CurrencyType type, int amount)
    {
        var reward = new Reward();
        reward.Resources.TryAdd(type, amount);

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
}