using Fallout.Shelter.Utilities.Factories;

namespace Fallout.Shelter.Utilities.Tests;

public class RoomFactoryTests
{
    private IRoomFactory _roomFactory = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _roomFactory = new RoomFactory();
    }

    [Test]
    public void CreateWasteland_CreateValidRoom()
    {
        var room = _roomFactory.CreateWasteland();

        room.Name.Should().Be("The Wasteland");
        room.IsElevator.Should().BeFalse();
        room.Price.Should().BeEmpty();
        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithItemPoolRefresh(), RewardFactory.CreateWithItem());

        room.Sectors[0].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Water, 2));

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithItem());

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Water, 1));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateVaultDoor_CreateValidRoom()
    {
        var room = _roomFactory.CreateVaultDoor();

        room.Name.Should().Be("Vault Door");
        room.IsElevator.Should().BeFalse();
        room.Price.Should().BeEmpty();
        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithFirstPlayerToken(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Luck));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithDweller());

        room.Sectors[1].Conditions.Should().HaveCount(3).And
            .ContainInOrder(ConditionFactory.CreateWithResources(ResourceType.Water, 1)).And
            .ContainInOrder(ConditionFactory.CreateWithResources(ResourceType.Food, 1)).And
            .ContainInOrder(ConditionFactory.CreateWithInjuredDweller());

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateVaultEntrance_CreateValidRoom()
    {
        var room = _roomFactory.CreateVaultEntrance();

        room.Name.Should().Be("Vault Entrance");
        room.IsElevator.Should().BeFalse();
        room.Price.Should().BeEmpty();
        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithDweller());

        room.Sectors[0].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Food, 3));

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithSpecialStat(SpecialStat.Any));

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateDefaultElevator_CreateValidRoom()
    {
        var room = _roomFactory.CreateDefaultElevator();

        room.Name.Should().Be("Elevator");
        room.IsElevator.Should().BeTrue();
        room.Price.Should().BeEmpty();
        room.Sectors.Should().HaveCount(1);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithDwellerHeal());

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = true
            });
    }

    [Test]
    public void CreatePlayerElevator_CreateValidRoom()
    {
        var room = _roomFactory.CreatePlayerElevator();

        room.Name.Should().Be("Elevator");
        room.IsElevator.Should().BeTrue();
        room.Price.Should().BeEmpty();
        room.Sectors.Should().HaveCount(1);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithHappiness(2),
                RewardFactory.CreateWithBuild());

        room.Sectors[0].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithBuild());

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateWaterTreatment_CreateValidRoom()
    {
        var room = _roomFactory.CreateWaterTreatment();

        room.Name.Should().Be("Water Treatment");
        room.IsElevator.Should().BeFalse();
        room.Price.Should().BeEmpty();
        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Water, 1));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Perception,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Water, 1));

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Perception,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateDiner_CreateValidRoom()
    {
        var room = _roomFactory.CreateDiner();

        room.Name.Should().Be("Diner");
        room.IsElevator.Should().BeFalse();
        room.Price.Should().BeEmpty();
        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Food, 2));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Agility,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Food, 1));

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Luck,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreatePowerGenerator_CreateValidRoom()
    {
        var room = _roomFactory.CreatePowerGenerator();

        room.Name.Should().Be("Power Generator");
        room.IsElevator.Should().BeFalse();
        room.Price.Should().BeEmpty();
        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Energy, 2));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Strength,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Energy, 1));

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Luck,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateWaterPurificationRoom_CreateValidRoom()
    {
        var room = _roomFactory.CreateWaterPurificationRoom();

        room.Name.Should().Be("Water Purification Room");
        room.IsElevator.Should().BeFalse();
        
        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new KeyValuePair<ResourceType,int>(ResourceType.Water, 2)).And 
            .ContainEquivalentOf(new KeyValuePair<ResourceType,int>(ResourceType.Energy, 3));
        
        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Water, 2));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Perception,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Water, 1));

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Luck,
                IsOnlyForInjuredDweller = false
            });
    }
}