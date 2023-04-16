using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public static class RewardFactory
{
    public static Reward CreateWithResources(ResourceType type, int amount)
    {
        var reward = new Reward
        {
            GiveResourceOfType = type,
            GiveResourceAmount = amount
        };

        return reward;
    }

    public static Reward CreateWithItem()
    {
        var reward = new Reward
        {
            GiveNewItem = true
        };

        return reward;
    }

    public static Reward CreateWithItemPoolRefresh()
    {
        var reward = new Reward
        {
            GiveItemPoolRefreshPossibility = true
        };

        return reward;
    }

    public static Reward CreateWithRoomPoolRefresh()
    {
        var reward = new Reward
        {
            GiveRoomPoolRefreshPossibility = true
        };

        return reward;
    }

    public static Reward CreateWithFirstPlayerToken()
    {
        var reward = new Reward
        {
            GiveFirstPlayerToken = true
        };

        return reward;
    }

    public static Reward CreateWithSpecialStat(SpecialStat stat)
    {
        var reward = new Reward
        {
            GiveSpecialStatToDweller = stat
        };

        return reward;
    }

    public static Reward CreateWithDweller()
    {
        var reward = new Reward
        {
            GiveNewDweller = true
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
            GiveBuildPossibility = true
        };

        return reward;
    }

    public static Reward CreateWithHappiness(int amount)
    {
        var reward = new Reward
        {
            GiveHappiness = amount
        };

        return reward;
    }

    public static Reward CreateWithExchange(KeyValuePair<ResourceType, int> from, KeyValuePair<ResourceType, int> to)
    {
        var reward = new Reward
        {
            ExchangeFrom = from,
            ExchangeTo = to,
            GiveResourceExchangePossibility = true
        };

        return reward;
    }

    public static Reward CreateWithActivateItem()
    {
        var reward = new Reward
        {
            GiveActivateItemPossibility = true
        };

        return reward;
    }
}