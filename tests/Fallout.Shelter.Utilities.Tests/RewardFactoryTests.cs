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

        reward.ResourceType.Should().Be(type);
        reward.ResourceAmount.Should().Be(amount);
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithItem_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithItem();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeTrue();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithItemPoolRefresh_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithItemPoolRefresh();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeTrue();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithFirstPlayerToken_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithFirstPlayerToken();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeTrue();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
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

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().NotBeNull().And.Be(stat);
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithDweller_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithDweller();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeTrue();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithDwellerHeal_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithDwellerHeal();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeTrue();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithBuild_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithBuild();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeTrue();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithHappiness_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithHappiness(5);

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().NotBeNull().And.Be(5);
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithActivateItem_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithActivateItem();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeTrue();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
    }

    [Test]
    public void CreateWithExchange_CreateValidReward()
    {
        var reward = RewardFactory.CreateWithExchange(new KeyValuePair<ResourceType, int>(ResourceType.Water, 4),
            new KeyValuePair<ResourceType, int>(ResourceType.Random, 3));

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Happiness.Should().BeNull();
        reward.NewDweller.Should().BeFalse();
        reward.FirstPlayerToken.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.SpecialStat.Should().BeNull();
        reward.ResourceExchange.Should().BeTrue();
        reward.HealDweller.Should().BeFalse();
        reward.NewItem.Should().BeFalse();
        reward.ActivateItem.Should().BeFalse();
        reward.RoomPoolRefresh.Should().BeFalse();
        reward.ItemPoolRefresh.Should().BeFalse();
        reward.ExchangeFrom.Should().NotBeNull().And.Be(new KeyValuePair<ResourceType, int>(ResourceType.Water, 4));
        reward.ExchangeTo.Should().NotBeNull().And.Be(new KeyValuePair<ResourceType, int>(ResourceType.Random, 3));
    }
}