using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public class RoomFactory : IRoomFactory
{
    public Room CreateWasteland()
    {
        var leftSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 2)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithItemPoolRefresh(),
                RewardFactory.CreateWithItem()
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 1)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithItem()
            }
        };

        return new Room("The Wasteland")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateVaultDoor()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithFirstPlayerToken(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Luck)
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 1),
                ConditionFactory.CreateWithResources(ResourceType.Food, 1),
                ConditionFactory.CreateWithInjuredDweller()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            }
        };

        return new Room("Vault Door")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateVaultEntrance()
    {
        var leftSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 3)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            }
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithSpecialStat(SpecialStat.Any)
            }
        };

        return new Room("Vault Entrance")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateDefaultElevator()
    {
        var space = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDwellerHeal()
            },
            IsOnlyForInjuredDweller = true
        };

        return new Room("Elevator", true)
        {
            Spaces =
            {
                [0] = space
            }
        };
    }

    public Room CreatePlayerElevator()
    {
        var space = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(2),
                RewardFactory.CreateWithBuild(),
            }
        };

        return new Room("Elevator", true)
        {
            Spaces =
            {
                [0] = space
            }
        };
    }

    public Room CreateWaterTreatment()
    {
        var space = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Water, 1)
            },
            SpecialStat = SpecialStat.Perception
        };

        return new Room("Water Treatment")
        {
            Spaces =
            {
                [0] = space,
                [1] = space
            }
        };
    }

    public Room CreateDiner()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 2)
            },
            SpecialStat = SpecialStat.Agility
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 1)
            },
            SpecialStat = SpecialStat.Luck
        };

        return new Room("Diner")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreatePowerGenerator()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Energy, 2)
            },
            SpecialStat = SpecialStat.Strength
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Energy, 1)
            },
            SpecialStat = SpecialStat.Luck
        };

        return new Room("Power Generator")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }
}