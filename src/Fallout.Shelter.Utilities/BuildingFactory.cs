using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public class BuildingFactory : IBuildingFactory
{
    public Building CreateWasteland()
    {
        var leftSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionBuilder.BuildWithResources(ResourceType.Water, 2)
            },
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithItemPoolRefresh(),
                RewardBuilder.BuildWithItem()
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionBuilder.BuildWithResources(ResourceType.Water, 1)
            },
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithItem()
            }
        };

        return new Building("The Wasteland")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Building CreateVaultDoor()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithFirstPlayerToken(),
                RewardBuilder.BuildWithSpecialStat(SpecialStat.Luck)
            }
        };

        var rightSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionBuilder.BuildWithResources(ResourceType.Water, 1),
                ConditionBuilder.BuildWithResources(ResourceType.Food, 1),
                ConditionBuilder.BuildWithInjuredDweller()
            },
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithDweller()
            }
        };

        return new Building("Vault Door")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Building CreateVaultEntrance()
    {
        var leftSpace = new Space
        {
            PriceToSpawn = new List<Condition>
            {
                ConditionBuilder.BuildWithResources(ResourceType.Food, 3)
            },
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithDweller()
            }
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithSpecialStat(SpecialStat.Any)
            }
        };

        return new Building("Vault Entrance")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Building CreateDefaultElevator()
    {
        var space = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithDwellerHeal()
            },
            IsOnlyForInjuredDweller = true
        };

        return new Building("Elevator", true)
        {
            Spaces =
            {
                [0] = space
            }
        };
    }

    public Building CreatePlayerElevator()
    {
        var space = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithHappiness(),
                RewardBuilder.BuildWithBuilding(),
            }
        };

        return new Building("Elevator", true)
        {
            Spaces =
            {
                [0] = space
            }
        };
    }

    public Building CreateWaterTreatment()
    {
        var space = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithResources(ResourceType.Water, 1)
            },
            SpecialStat = SpecialStat.Perception
        };

        return new Building("Water Treatment")
        {
            Spaces =
            {
                [0] = space,
                [1] = space
            }
        };
    }

    public Building CreateDiner()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithResources(ResourceType.Food, 2)
            },
            SpecialStat = SpecialStat.Agility
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithResources(ResourceType.Food, 1)
            },
            SpecialStat = SpecialStat.Luck
        };

        return new Building("Diner")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }

    public Building CreatePowerGenerator()
    {
        var leftSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithResources(ResourceType.Energy, 2)
            },
            SpecialStat = SpecialStat.Strength
        };

        var rightSpace = new Space
        {
            Rewards = new List<Reward>
            {
                RewardBuilder.BuildWithResources(ResourceType.Energy, 1)
            },
            SpecialStat = SpecialStat.Luck
        };

        return new Building("Power Generator")
        {
            Spaces =
            {
                [0] = leftSpace,
                [1] = rightSpace
            }
        };
    }
}