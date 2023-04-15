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
    Room CreateNukaColaBottler();
    Room CreateNuclearReactor();
    Room CreateGarden();
    Room CreateClassroom();
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
    Room CreateThemeWorkshopRoom();
    Room CreateOutfitWorkshopRoom();
    Room CreateWeaponWorkshopRoom();
}