using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public interface IRoomFactory
{
    Room CreateWasteland();
    Room CreateVaultDoor();
    Room CreateVaultEntrance();
    Room CreateDefaultElevator();
    Room CreatePlayerElevator();
    Room CreateWaterTreatment();
    Room CreateDiner();
    Room CreatePowerGenerator();
}