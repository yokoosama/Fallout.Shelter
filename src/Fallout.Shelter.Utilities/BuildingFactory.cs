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
                ConditionBuilder.BuildWithResources(CurrencyType.Water, 2)
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
                ConditionBuilder.BuildWithResources(CurrencyType.Water, 1)
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
        return new Building("Vault Door");
    }

    public Building CreateVaultEntrance()
    {
        return new Building("Vault Entrance");
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