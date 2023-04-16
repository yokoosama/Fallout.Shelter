using Fallout.Shelter.Core.Enums;
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
                RewardFactory.CreateWithExchange(new Resource(ResourceType.Water, 1),
                    new Resource(ResourceType.Food, 2))
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
                RewardFactory.CreateWithExchange(new Resource(ResourceType.Energy, 1),
                    new Resource(ResourceType.Food, 1))
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Storage Room")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Water, 1),
                new(ResourceType.Food, 1),
                new(ResourceType.Energy, 2)
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
            Price = new List<Resource>
            {
                new(ResourceType.Water, 2),
                new(ResourceType.Energy, 3)
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
            Price = new List<Resource>
            {
                new(ResourceType.Water, 1),
                new(ResourceType.Food, 1),
                new(ResourceType.Energy, 3)
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
            Price = new List<Resource>
            {
                new(ResourceType.Energy, 5)
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
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Agility
                }
            }
        };

        return new Room("Garden")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Food, 2),
                new(ResourceType.Energy, 3)
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
            Price = new List<Resource>
            {
                new(ResourceType.Food, 1),
                new(ResourceType.Energy, 3)
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
            Price = new List<Resource>
            {
                new(ResourceType.Food, 3),
                new(ResourceType.Energy, 1)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateArmory()
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

        return new Room("Armory")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Water, 2),
                new(ResourceType.Energy, 2)
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
            Price = new List<Resource>
            {
                new(ResourceType.Random, 4),
                new(ResourceType.Energy, 1)
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
            Price = new List<Resource>
            {
                new(ResourceType.Energy, 4)
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
            Price = new List<Resource>
            {
                new(ResourceType.Water, 1),
                new(ResourceType.Energy, 3)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateLounge()
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
                ConditionFactory.CreateWithResources(ResourceType.Food, 1)
            },
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
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

        return new Room("Lounge")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Food, 2),
                new(ResourceType.Energy, 2)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateMedbay()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDwellerHeal(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Endurance)
            },
            Spaces =
            {
                [0] = new Space
                {
                    IsOnlyForInjuredDweller = true
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
                RewardFactory.CreateWithSpecialStat(SpecialStat.Any),
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

        return new Room("Medbay")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Random, 1),
                new(ResourceType.Energy, 3)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateScienceLab()
    {
        var leftSpace = new RoomSector
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDwellerHeal(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Intelligence)
            },
            Spaces =
            {
                [0] = new Space
                {
                    IsOnlyForInjuredDweller = true
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
                RewardFactory.CreateWithSpecialStat(SpecialStat.Any),
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

        return new Room("Science Lab")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Random, 1),
                new(ResourceType.Energy, 3)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateRadioStudio()
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
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Charisma
                }
            }
        };

        return new Room("Radio Studio")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Water, 1),
                new(ResourceType.Energy, 3)
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
        var leftSpace = new RoomSector(2)
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithDweller()
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Charisma
                },
                [1] = new Space()
            }
        };

        var rightSpace = new RoomSector(2)
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
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Charisma
                },
                [1] = new Space()
            }
        };

        return new Room("Living Room")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Water, 2),
                new(ResourceType.Energy, 2)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateThemeWorkshop()
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
                RewardFactory.CreateWithRoomPoolRefresh(),
                RewardFactory.CreateWithSpecialStat(SpecialStat.Any)
            },
            Spaces =
            {
                [0] = new Space()
            }
        };

        return new Room("Theme Workshop")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Energy, 5)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateOutfitWorkshop()
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
                [0] = new Space
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
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Intelligence
                }
            }
        };

        return new Room("Outfit Workshop")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Water, 2),
                new(ResourceType.Energy, 3)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Room CreateWeaponWorkshop()
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
                [0] = new Space
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
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Intelligence
                }
            }
        };

        return new Room("Weapon Workshop")
        {
            Price = new List<Resource>
            {
                new(ResourceType.Water, 2),
                new(ResourceType.Energy, 3)
            },
            Sectors =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }
}