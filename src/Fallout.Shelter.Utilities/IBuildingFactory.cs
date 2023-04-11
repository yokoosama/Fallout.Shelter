using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public interface IBuildingFactory
{
    Building CreateWasteland();
    Building CreateVaultDoor();
    Building CreateVaultEntrance();
    Building CreateDefaultElevator();
    Building CreatePlayerElevator();
    Building CreateWaterTreatment();
    Building CreateDiner();
    Building CreatePowerGenerator();
}