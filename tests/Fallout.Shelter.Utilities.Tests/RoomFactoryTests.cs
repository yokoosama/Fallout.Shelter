using Fallout.Shelter.Core.Enums;
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
            .ContainEquivalentOf(new Resource(ResourceType.Water, 2)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

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

    [Test]
    public void CreateNukaColaBottler_CreateValidRoom()
    {
        var room = _roomFactory.CreateNukaColaBottler();

        room.Name.Should().Be("Nuka-Cola Bottler");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(3).And
            .ContainEquivalentOf(new Resource(ResourceType.Water, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Food, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Food, 1)).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Water, 1));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Luck,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(2).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Food, 2)).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Water, 1));

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Endurance,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateNuclearReactor_CreateValidRoom()
    {
        var room = _roomFactory.CreateNuclearReactor();

        room.Name.Should().Be("Nuclear Reactor");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(1).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 5));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Energy, 2));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Luck,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Energy, 3));

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Strength,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateGarden_CreateValidRoom()
    {
        var room = _roomFactory.CreateGarden();

        room.Name.Should().Be("Garden");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Food, 2)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Food, 2));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Luck,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Food, 3));

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Agility,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateClassroom_CreateValidRoom()
    {
        var room = _roomFactory.CreateClassroom();

        room.Name.Should().Be("Classroom");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Food, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1)).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Intelligence));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithHappiness(1));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Random, 4));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateAthleticsRoom_CreateValidRoom()
    {
        var room = _roomFactory.CreateAthleticsRoom();

        room.Name.Should().Be("Athletics Room");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Food, 3)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 1));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1)).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Agility));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithHappiness(1));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Food, 3));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateArmory_CreateValidRoom()
    {
        var room = _roomFactory.CreateArmory();

        room.Name.Should().Be("Armory");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Water, 2)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 2));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1)).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Perception));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithHappiness(1));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Water, 2));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateGameRoom_CreateValidRoom()
    {
        var room = _roomFactory.CreateGameRoom();

        room.Name.Should().Be("Game Room");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Random, 4)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 1));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1)).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Luck));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithHappiness(1));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithInjuredDweller());

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateWeightRoom_CreateValidRoom()
    {
        var room = _roomFactory.CreateWeightRoom();

        room.Name.Should().Be("Weight Room");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(1).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 4));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1)).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Strength));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithHappiness(1));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Energy, 3));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateFitnessRoom_CreateValidRoom()
    {
        var room = _roomFactory.CreateFitnessRoom();

        room.Name.Should().Be("Fitness Room");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Water, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1)).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Endurance));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithHappiness(1));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithItem());

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateStorageRoom_CreateValidRoom()
    {
        var room = _roomFactory.CreateStorageRoom();

        room.Name.Should().Be("Storage Room");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(3).And
            .ContainEquivalentOf(new Resource(ResourceType.Water, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Food, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 2));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithExchange(
                new Resource(ResourceType.Water, 1),
                new Resource(ResourceType.Food, 2)));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithExchange(
                new Resource(ResourceType.Energy, 1),
                new Resource(ResourceType.Food, 1)));

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
    public void CreateLounge_CreateValidRoom()
    {
        var room = _roomFactory.CreateLounge();

        room.Name.Should().Be("Lounge");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Food, 2)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 2));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1)).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Charisma));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithDwellerHeal()).And
            .ContainInOrder(RewardFactory.CreateWithHappiness(1));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Food, 1));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = true
            });
    }

    [Test]
    public void CreateMedbay_CreateValidRoom()
    {
        var room = _roomFactory.CreateMedbay();

        room.Name.Should().Be("Medbay");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Random, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithDwellerHeal()).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Endurance));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = true
            });

        room.Sectors[1].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithDwellerHeal()).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Any));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Food, 1));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = true
            });
    }

    [Test]
    public void CreateScienceLab_CreateValidRoom()
    {
        var room = _roomFactory.CreateScienceLab();

        room.Name.Should().Be("Science Lab");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Random, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithDwellerHeal()).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Intelligence));

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = true
            });

        room.Sectors[1].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithDwellerHeal()).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Any));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Food, 1));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = true
            });
    }

    [Test]
    public void CreateRadioStudio_CreateValidRoom()
    {
        var room = _roomFactory.CreateRadioStudio();

        room.Name.Should().Be("Radio Studio");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Water, 1)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithDweller());

        room.Sectors[0].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Food, 2));

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithDweller());

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Food, 3));

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Charisma,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateLivingRoom_CreateValidRoom()
    {
        var room = _roomFactory.CreateLivingRoom();

        room.Name.Should().Be("Living Room");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Water, 2)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 2));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithDweller());

        room.Sectors[0].Conditions.Should().BeEmpty();

        room.Sectors[0].Spaces.Should().HaveCount(2).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Charisma,
                IsOnlyForInjuredDweller = false
            }).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithDweller());

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Food, 1));

        room.Sectors[1].Spaces.Should().HaveCount(2).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Charisma,
                IsOnlyForInjuredDweller = false
            }).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Charisma,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateThemeWorkshop_CreateValidRoom()
    {
        var room = _roomFactory.CreateThemeWorkshop();

        room.Name.Should().Be("Theme Workshop");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(1).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 5));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithHappiness(1)).And
            .ContainInOrder(RewardFactory.CreateWithBuild());

        room.Sectors[0].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithBuild());

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = null,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(2).And
            .ContainInOrder(RewardFactory.CreateWithRoomPoolRefresh()).And
            .ContainInOrder(RewardFactory.CreateWithSpecialStat(SpecialStat.Any));

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
    public void CreateOutfitWorkshop_CreateValidRoom()
    {
        var room = _roomFactory.CreateOutfitWorkshop();

        room.Name.Should().Be("Outfit Workshop");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Water, 2)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithItem());

        room.Sectors[0].Conditions.Should().HaveCount(2).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Water, 1)).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Random, 1));

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Intelligence,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithResources(ResourceType.Random, 3));

        room.Sectors[1].Conditions.Should().HaveCount(1).And
            .ContainEquivalentOf(ConditionFactory.CreateWithItem());

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Intelligence,
                IsOnlyForInjuredDweller = false
            });
    }

    [Test]
    public void CreateWeaponWorkshop_CreateValidRoom()
    {
        var room = _roomFactory.CreateWeaponWorkshop();

        room.Name.Should().Be("Weapon Workshop");
        room.IsElevator.Should().BeFalse();

        room.Price.Should().HaveCount(2).And
            .ContainEquivalentOf(new Resource(ResourceType.Water, 2)).And
            .ContainEquivalentOf(new Resource(ResourceType.Energy, 3));

        room.Sectors.Should().HaveCount(2);

        room.Sectors[0].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithItem());

        room.Sectors[0].Conditions.Should().HaveCount(2).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Water, 1)).And
            .ContainEquivalentOf(ConditionFactory.CreateWithResources(ResourceType.Random, 1));

        room.Sectors[0].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Intelligence,
                IsOnlyForInjuredDweller = false
            });

        room.Sectors[1].Rewards.Should().HaveCount(1).And
            .ContainEquivalentOf(RewardFactory.CreateWithActivateItem());

        room.Sectors[1].Conditions.Should().BeEmpty();

        room.Sectors[1].Spaces.Should().HaveCount(1).And
            .ContainEquivalentOf(new Space
            {
                Dweller = null,
                SpecialStat = SpecialStat.Intelligence,
                IsOnlyForInjuredDweller = false
            });
    }
}