using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public class RoomFactory : IRoomFactory
{
    public Room CreateWasteland()
    {
        var leftSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 2)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithItemPoolRefresh(),
                RewardFactory.CreateWithItem()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 1)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithItem()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("The Wasteland")
        {
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateVaultDoor()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithFirstPlayerToken(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Luck)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 1),
                ConditionFactory.CreateWithResources(ResourceType.Food, 1),
                ConditionFactory.CreateWithInjuredDweller()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Vault Door")
        {
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateVaultEntrance()
    {
        var leftSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 3)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithSpecialStat(SpecialStat.Any)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Vault Entrance")
        {
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateDefaultElevator()
    {
        var space = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDwellerHeal()
            },
            Spaces =
            {
                [0] = new Space
                {
                    IsOnlyForInjuredDweller = true
                }
            }
        };

        return new Room("Elevator", true)
        {
            Sectors =
            {
                [0] = space
            }
        };
    }

    public Room CreatePlayerElevator()
    {
        var space = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(2),
                RewardFactory.CreateWithBuild()
            },
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithBuild()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Elevator", true)
        {
            Sectors =
            {
                [0] = space
            }
        };
    }

    public Room CreateWaterTreatment()
    {
        var space = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Water, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Perception
                }
            }
        };

        return new Room("Water Treatment")
        {
            Sectors =
            {
                [0] = space,
                [1] = space
            }
        };
    }

    public Room CreateDiner()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 2)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Agility
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Luck
                }
            }
        };

        return new Room("Diner")
        {
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreatePowerGenerator()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Energy, 2)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Strength
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Energy, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Luck
                }
            }
        };

        return new Room("Power Generator")
        {
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateStorageRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithExchange(new KeyValuePair<ResourceType, int>(ResourceType.Water, 1),
                    new KeyValuePair<ResourceType, int>(ResourceType.Food, 2))
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Perception
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithExchange(new KeyValuePair<ResourceType, int>(ResourceType.Energy, 1),
                    new KeyValuePair<ResourceType, int>(ResourceType.Food, 1))
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Perception
                }
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
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateWaterPurificationRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Water, 2)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Perception
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Water, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Luck
                }
            }
        };

        return new Room("Water Purification Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 2 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateNukaColaBottler()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 1),
                RewardFactory.CreateWithResources(ResourceType.Water, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Luck
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 2),
                RewardFactory.CreateWithResources(ResourceType.Water, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Endurance
                }
            }
        };

        return new Room("Nuka-Cola Bottler")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 1 },
                { ResourceType.Food, 1 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateNuclearReactor()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Energy, 2)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Luck
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Energy, 3)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Strength
                }
            }
        };

        return new Room("Nuclear Reactor")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Energy, 5 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateGarden()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 2)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Luck
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Food, 3)
            },
            Spaces =
            {
                [0] = new Space()
                {
                    SpecialStat = SpecialStat.Agility
                }
            }
        };

        return new Room("Garden")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Food, 2 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateClassroom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Intelligence)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Random, 4)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Classroom")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Food, 1 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateAthleticsRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Agility)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 3)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Athletics Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Food, 3 },
                { ResourceType.Energy, 1 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateArmoryRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Perception)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 2)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Armory Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 2 },
                { ResourceType.Energy, 2 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateGameRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Luck)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithInjuredDweller()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Game Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Random, 4 },
                { ResourceType.Energy, 1 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateWeightRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Strength)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Energy, 3)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Weight Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Energy, 4 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateFitnessRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Endurance)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithItem()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Fitness Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 1 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateLoungeRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Charisma)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 1),
                ConditionFactory.CreateWithInjuredDweller()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
                RewardFactory.CreateWithDwellerHeal()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Lounge Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Food, 2 },
                { ResourceType.Energy, 2 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateMedbayRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDwellerHeal(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Endurance)
            },
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithInjuredDweller()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 1),
                ConditionFactory.CreateWithInjuredDweller()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithSpecialStat(SpecialStat.Any),
                RewardFactory.CreateWithDwellerHeal()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Medbay Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Random, 1 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateScienceLabRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDwellerHeal(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Intelligence)
            },
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithInjuredDweller()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 1),
                ConditionFactory.CreateWithInjuredDweller()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithSpecialStat(SpecialStat.Any),
                RewardFactory.CreateWithDwellerHeal()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Science Lab Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Random, 1 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateRadioStudioRoom()
    {
        var leftSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 2)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 3)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            },
            Spaces =
            {
                [0] = new Space()
                {
                    SpecialStat = SpecialStat.Charisma
                }
            }
        };

        return new Room("Radio Studio Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 1 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateLivingRoom()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            },
            Spaces =
            {
                [0] = new Space()
                {
                    SpecialStat = SpecialStat.Charisma
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Food, 1)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            },
            Spaces =
            {
                [0] = new Space()
                {
                    SpecialStat = SpecialStat.Charisma
                }
            }
        };

        return new Room("Living Room")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 2 },
                { ResourceType.Energy, 2 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateThemeWorkshopRoom()
    {
        var leftSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithBuild()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
                RewardFactory.CreateWithBuild()
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithItemPoolRefresh(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Any)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Theme Workshop")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Energy, 5 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateOutfitWorkshopRoom()
    {
        var leftSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 1),
                ConditionFactory.CreateWithResources(ResourceType.Random, 1)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithItem()
            },
            Spaces =
            {
                [0] = new Space()
                {
                    SpecialStat = SpecialStat.Intelligence
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithItem()
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 3)
            },
            Spaces =
            {
                [0] = new Space()
                {
                    SpecialStat = SpecialStat.Intelligence
                }
            }
        };

        return new Room("Outfit Workshop")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Water, 2 },
                { ResourceType.Energy, 3 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateWeaponWorkshopRoom()
    {
        var leftSpace = new RoomSector
        {
            Conditions = new List<Condition>
            {
                ConditionFactory.CreateWithResources(ResourceType.Water, 1),
                ConditionFactory.CreateWithResources(ResourceType.Random, 1)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithItem()
            },
            Spaces =
            {
                [0] = new Space()
                {
                    SpecialStat = SpecialStat.Intelligence
                }
            }
        };

        var rightSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithActivateItem()
            },
            Spaces =
            {
                [0] = new Space()
                {
                    SpecialStat = SpecialStat.Intelligence
                }
            }
        };

        return new Room("Weapon Workshop")
        {
            Price = new Dictionary<ResourceType, int>
            {
                { ResourceType.Energy, 5 }
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }
}