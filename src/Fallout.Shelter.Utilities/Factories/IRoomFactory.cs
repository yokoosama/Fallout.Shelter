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
    Room CreateArmory();
    Room CreateGameRoom();
    Room CreateWeightRoom();
    Room CreateFitnessRoom();
    Room CreateStorageRoom();
    Room CreateLounge();
    Room CreateMedbay();
    Room CreateScienceLab();
    Room CreateRadioStudio();
    Room CreateLivingRoom();
    Room CreateThemeWorkshopRoom();
    Room CreateOutfitWorkshopRoom();
    Room CreateWeaponWorkshopRoom();
}