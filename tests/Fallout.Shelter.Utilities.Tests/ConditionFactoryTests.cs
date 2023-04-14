using Fallout.Shelter.Utilities.Factories;

namespace Fallout.Shelter.Utilities.Tests;

public class ConditionFactoryTests
{
    [TestCase(ResourceType.Water, 4)]
    [TestCase(ResourceType.Food, 2)]
    [TestCase(ResourceType.Energy, 3)]
    [TestCase(ResourceType.Random, 5)]
    public void CreateWithResources_CreateValidReward(ResourceType type, int amount)
    {
        var reward = ConditionFactory.CreateWithResources(type, amount);

        reward.ResourceType.Should().Be(type);
        reward.ResourceAmount.Should().Be(amount);
        reward.Item.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.InjureDweller.Should().BeFalse();
        reward.Roll.Should().BeNull();
    }

    [Test]
    public void CreateWithInjuredDweller_CreateValidReward()
    {
        var reward = ConditionFactory.CreateWithInjuredDweller();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Item.Should().BeFalse();
        reward.Build.Should().BeFalse();
        reward.InjureDweller.Should().BeTrue();
        reward.Roll.Should().BeNull();
    }

    [Test]
    public void CreateWithItem_CreateValidReward()
    {
        var reward = ConditionFactory.CreateWithItem();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Item.Should().BeTrue();
        reward.Build.Should().BeFalse();
        reward.InjureDweller.Should().BeFalse();
        reward.Roll.Should().BeNull();
    }

    [Test]
    public void CreateWithBuild_CreateValidReward()
    {
        var reward = ConditionFactory.CreateWithBuild();

        reward.ResourceType.Should().BeNull();
        reward.ResourceAmount.Should().BeNull();
        reward.Item.Should().BeFalse();
        reward.Build.Should().BeTrue();
        reward.InjureDweller.Should().BeFalse();
        reward.Roll.Should().BeNull();
    }
}