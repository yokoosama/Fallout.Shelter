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
    Room CreateWaterPurificationRoom();
    Room CreateNukaColaBottlerRoom();
    Room CreateNuclearReactorRoom();
    Room CreateGardenRoom();
    Room CreateClassRoom();
    Room CreateAthleticsRoom();
    Room CreateArmoryRoom();
    Room CreateGameRoom();
    Room CreateWeightRoom();
    Room CreateFitnessRoom();
    Room CreateStorageRoom();
    Room CreateLoungeRoom();
    Room CreateMedbayRoom();
    Room CreateScienceLabRoom();
    Room CreateRadioStudioRoom();
    Room CreateLivingRoom();
}