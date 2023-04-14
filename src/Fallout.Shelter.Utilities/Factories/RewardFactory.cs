using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public static class RewardFactory
{
    public static Reward CreateWithResources(ResourceType type, int amount)
    {
        var reward = new Reward
        {
            ResourceType = type,
            ResourceAmount = amount
        };

        return reward;
    }

    public static Reward CreateWithItem()
    {
        var reward = new Reward
        {
            NewItem = true
        };

        return reward;
    }

    public static Reward CreateWithItemPoolRefresh()
    {
        var reward = new Reward
        {
            ItemPoolRefresh = true
        };

        return reward;
    }

    public static Reward CreateWithFirstPlayerToken()
    {
        var reward = new Reward
        {
            FirstPlayerToken = true
        };

        return reward;
    }

    public static Reward CreateWithSpecialStat(SpecialStat stat)
    {
        var reward = new Reward
        {
            SpecialStat = stat
        };

        return reward;
    }

    public static Reward CreateWithDweller()
    {
        var reward = new Reward
        {
            NewDweller = true
        };

        return reward;
    }

    public static Reward CreateWithDwellerHeal()
    {
        var reward = new Reward
        {
            HealDweller = true
        };

        return reward;
    }

    public static Reward CreateWithBuild()
    {
        var reward = new Reward
        {
            Build = true
        };

        return reward;
    }

    public static Reward CreateWithHappiness(int amount)
    {
        var reward = new Reward
        {
            Happiness = amount
        };

        return reward;
    }

    public static Reward CreateWithExchange(KeyValuePair<ResourceType, int> from, KeyValuePair<ResourceType, int> to)
    {
        var reward = new Reward
        {
            ExchangeFrom = from,
            ExchangeTo = to,
            ResourceExchange = true
        };

        return reward;
    }

    public static Reward CreateWithActivateItem()
    {
        var reward = new Reward
        {
            ActivateItem = true
        };

        return reward;
    }
}