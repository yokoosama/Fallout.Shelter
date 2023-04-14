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
}