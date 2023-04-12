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
                RewardFactory.CreateWithBuild()
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

    public Room CreateStorageRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithExchange(new KeyValuePair<ResourceType, int>(ResourceType.Water, 1),
                    new KeyValuePair<ResourceType, int>(ResourceType.Food, 2))
            }
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithExchange(new KeyValuePair<ResourceType, int>(ResourceType.Energy, 1),
                    new KeyValuePair<ResourceType, int>(ResourceType.Food, 1))
            }
        };

        return new Room("Storage Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 1 },
                { ResourceType.Food, 1 },
                { ResourceType.Energy, 2 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateWaterPurificationRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Water, 2)
            },
            SpecialStat = SpecialStat.Perception
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Water, 1)
            },
            SpecialStat = SpecialStat.Luck
        };

        return new Room("Water Purification Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 2 },
                { ResourceType.Energy, 3 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateNukaColaBottlerRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 1),
                RewardFactory.CreateWithResources(ResourceType.Water, 1)
            },
            SpecialStat = SpecialStat.Luck
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 2),
                RewardFactory.CreateWithResources(ResourceType.Water, 1)
            },
            SpecialStat = SpecialStat.Endurance
        };

        return new Room("Nuka-Cola Bottler Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 1 },
                { ResourceType.Food, 1 },
                { ResourceType.Energy, 3 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateNuclearReactorRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Energy, 2)
            },
            SpecialStat = SpecialStat.Luck
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Energy, 3)
            },
            SpecialStat = SpecialStat.Strength
        };

        return new Room("Nuclear Reactor Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Energy, 5 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateGardenRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 2)
            },
            SpecialStat = SpecialStat.Luck
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 3)
            },
            SpecialStat = SpecialStat.Agility
        };

        return new Room("Garden Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Food, 2 },
                { ResourceType.Energy, 3 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateClassRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Intelligence)
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Random, 4)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            }
        };

        return new Room("Class Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Food, 1 },
                { ResourceType.Energy, 3 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateAthleticsRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Agility)
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 3)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            }
        };

        return new Room("Athletics Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Food, 3 },
                { ResourceType.Energy, 1 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateArmoryRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Perception)
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 2)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            }
        };

        return new Room("Armory Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 2 },
                { ResourceType.Energy, 2 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateGameRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Luck)
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithInjuredDweller()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            }
        };

        return new Room("Game Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Random, 4 },
                { ResourceType.Energy, 1 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateWeightRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Strength)
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Energy, 3)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            }
        };

        return new Room("Weight Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Energy, 4 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateFitnessRoom()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Endurance)
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionFactory.CreateWithItem()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            }
        };

        return new Room("Fitness Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 1 },
                { ResourceType.Energy, 3 }
            },
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }
}