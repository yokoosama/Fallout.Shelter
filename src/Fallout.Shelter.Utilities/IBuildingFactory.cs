using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public interface IBuildingFactory
{
    Building CreateWasteland();
    Building CreateVaultDoor();
    Building CreateVaultEntrance();
    Building CreateElevator();
    Building CreateWaterTreatment();
    Building CreateDiner();
    Building CreatePowerGenerator();
}