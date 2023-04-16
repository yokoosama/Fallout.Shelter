using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Utilities.Factories;

namespace Fallout.Shelter.Utilities.Tests;

public class RewardFactoryTests
{
    [TestCase(ResourceType.Water, 4)]
    [TestCase(ResourceType.Food, 2)]
    [TestCase(ResourceType.Energy, 3)]
    [TestCase(ResourceType.Random, 5)]
    public void CreateWithResources_CreateValidReward(ResourceType type, int amount)
    {
        var reward = RewardFactory.CreateWithResources(type, amount);

        reward.GiveResourceOfType.Should().Be(type);
        reward.GiveResourceAmount.Should().Be(amount);
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithItem_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithItem();

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeTrue();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithItemPoolRefresh_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithItemPoolRefresh();

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeTrue();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithFirstPlayerToken_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithFirstPlayerToken();

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeTrue();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [TestCase(SpecialStat.Strength)]
    [TestCase(SpecialStat.Perception)]
    [TestCase(SpecialStat.Endurance)]
    [TestCase(SpecialStat.Charisma)]
    [TestCase(SpecialStat.Intelligence)]
    [TestCase(SpecialStat.Agility)]
    [TestCase(SpecialStat.Luck)]
    [TestCase(SpecialStat.Any)]
    public void CreateWithSpecialStat_CreateValidReward(SpecialStat stat)
    {
        var reward = RewardFactory.CreateWithSpecialStat(stat);

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().NotBeNull().And.Be(stat);
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithDweller_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithDweller();

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeTrue();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithDwellerHeal_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithDwellerHeal();

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeTrue();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithBuild_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithBuild();

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeTrue();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithHappiness_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithHappiness(5);

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().NotBeNull().And.Be(5);
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithActivateItem_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithActivateItem();

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeTrue();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithExchange_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithExchange(new KeyValuePair<ResourceType, int>(ResourceType.Water, 4),
            new KeyValuePair<ResourceType, int>(ResourceType.Random, 3));

        reward.GiveResourceOfType.Should().BeNull();
        reward.GiveResourceAmount.Should().BeNull();
        reward.GiveHappiness.Should().BeNull();
        reward.GiveNewDweller.Should().BeFalse();
        reward.GiveFirstPlayerToken.Should().BeFalse();
        reward.GiveBuildPossibility.Should().BeFalse();
        reward.GiveSpecialStatToDweller.Should().BeNull();
        reward.GiveResourceExchangePossibility.Should().BeTrue();
        reward.HealDweller.Should().BeFalse();
        reward.GiveNewItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveRoomPoolRefreshPossibility.Should().BeFalse();
        reward.GiveItemPoolRefreshPossibility.Should().BeFalse();
        reward.ExchangeFrom.Should().NotBeNull().And.Be(new KeyValuePair<ResourceType, int>(ResourceType.Water, 4));
        reward.ExchangeTo.Should().NotBeNull().And.Be(new KeyValuePair<ResourceType, int>(ResourceType.Random, 3));
    }
}