using Fallout.Shelter.Core.Enums;
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

        reward.ShouldThrowResourceOfType.Should().Be(type);
        reward.ShouldThrowResourceAmount.Should().Be(amount);
        reward.ShouldThrowItem.Should().BeFalse();
        reward.ShouldBuild.Should().BeFalse();
        reward.ShouldInjureDweller.Should().BeFalse();
    }

    [Test]
    public void CreateWithInjuredDweller_CreateValidReward()
    {
        var reward = ConditionFactory.CreateWithInjuredDweller();

        reward.ShouldThrowResourceOfType.Should().BeNull();
        reward.ShouldThrowResourceAmount.Should().BeNull();
        reward.ShouldThrowItem.Should().BeFalse();
        reward.ShouldBuild.Should().BeFalse();
        reward.ShouldInjureDweller.Should().BeTrue();
    }

    [Test]
    public void CreateWithItem_CreateValidReward()
    {
        var reward = ConditionFactory.CreateWithItem();

        reward.ShouldThrowResourceOfType.Should().BeNull();
        reward.ShouldThrowResourceAmount.Should().BeNull();
        reward.ShouldThrowItem.Should().BeTrue();
        reward.ShouldBuild.Should().BeFalse();
        reward.ShouldInjureDweller.Should().BeFalse();
    }

    [Test]
    public void CreateWithBuild_CreateValidReward()
    {
        var reward = ConditionFactory.CreateWithBuild();

        reward.ShouldThrowResourceOfType.Should().BeNull();
        reward.ShouldThrowResourceAmount.Should().BeNull();
        reward.ShouldThrowItem.Should().BeFalse();
        reward.ShouldBuild.Should().BeTrue();
        reward.ShouldInjureDweller.Should().BeFalse();
    }
}