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

    public Building CreateElevator()
    {
        return new Building("Elevator", true);
    }

    public Building CreateWaterTreatment()
    {
        return new Building("Water Treatment");
    }

    public Building CreateDiner()
    {
        return new Building("Diner");
    }

    public Building CreatePowerGenerator()
    {
        return new Building("Power Generator");
    }
}