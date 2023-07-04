using Fallout.Shelter.Core.Models;
using Fallout.Shelter.Utilities.Extensions;

namespace Fallout.Shelter.Utilities.Factories;

public class GameFieldFactory
{
    public GameField CreateGameField(int playersCount)
    {
        if (playersCount is > 4 or < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(playersCount), "Maximum players count is 4 and minimum is 2");
        }

        var field = new GameField(playersCount)
        {
            Field = CreateDefaultRooms(playersCount),
            RoomPool = CreateRoomPool().Shuffle().ToStack(),
            ItemPool = CreateItemPool().Shuffle().ToStack(),
            ThreatPool = CreateThreatPool().Shuffle().ToStack()
        };

        return field;
    }

    private Room[,] CreateDefaultRooms(int playersCount)
    {
        var field = new Room[playersCount + 1, 7];
        field[0, 0] = RoomFactory.CreateWasteland();
        field[0, 1] = RoomFactory.CreateVaultDoor();
        field[0, 2] = RoomFactory.CreateVaultEntrance();
        field[0, 3] = RoomFactory.CreateDefaultElevator();
        field[0, 4] = RoomFactory.CreateWaterTreatment();
        field[0, 5] = RoomFactory.CreateDiner();
        field[0, 6] = RoomFactory.CreatePowerGenerator();

        for (var i = 1; i < playersCount; i++)
        {
            field[i, 7] = RoomFactory.CreatePlayerElevator();
        }

        return field;
    }

    private static List<Room> CreateRoomPool()
    {
        var roomPool = new List<Room>(30)
        {
            RoomFactory.CreateWaterPurificationRoom(),
            RoomFactory.CreateWaterPurificationRoom(),
            RoomFactory.CreateNukaColaBottler(),
            RoomFactory.CreateNukaColaBottler(),
            RoomFactory.CreateNuclearReactor(),
            RoomFactory.CreateNuclearReactor(),
            RoomFactory.CreateGarden(),
            RoomFactory.CreateGarden(),
            RoomFactory.CreateClassroom(),
            RoomFactory.CreateAthleticsRoom(),
            RoomFactory.CreateArmory(),
            RoomFactory.CreateGameRoom(),
            RoomFactory.CreateWeightRoom(),
            RoomFactory.CreateFitnessRoom(),
            RoomFactory.CreateStorageRoom(),
            RoomFactory.CreateLounge(),
            RoomFactory.CreateMedbay(),
            RoomFactory.CreateScienceLab(),
            RoomFactory.CreateRadioStudio(),
            RoomFactory.CreateLivingRoom(),
            RoomFactory.CreateLivingRoom(),
            RoomFactory.CreateThemeWorkshop(),
            RoomFactory.CreateOutfitWorkshop(),
            RoomFactory.CreateWeaponWorkshop()
        };

        return roomPool;
    }

    private static List<Item> CreateItemPool()
    {
        var itemPool = new List<Item>(31)
        {
            ItemFactory.CreateGoldenRetriever(),
            ItemFactory.CreateStimpak(),
            ItemFactory.CreatePistol(),
            ItemFactory.CreateMinigun(),
            ItemFactory.CreatePlasmaPistol(),
            ItemFactory.CreateLaserRifle(),
            ItemFactory.CreateShotgun(),
            ItemFactory.CreateWastelandGear(),
            ItemFactory.CreateNightwear(),
            ItemFactory.CreateFormalWear(),
            ItemFactory.CreateMilitaryFatigues(),
            ItemFactory.CreateHandymanJumpsuit(),
            ItemFactory.CreateArmoredVaultSuit(),
            ItemFactory.CreateLabCoat(),
            ItemFactory.CreateScottishFold(),
            ItemFactory.CreateMissileLauncher(),
            ItemFactory.CreateFatMan(),
            ItemFactory.CreateGiddyupButtercup(),
            ItemFactory.CreateYaoGuaiHide(),
            ItemFactory.CreateMilitaryDuctTape(),
            ItemFactory.CreateChemistryFlask(),
            ItemFactory.CreateMilitaryCircuitBoard(),
            ItemFactory.CreateGoldWatch(),
            ItemFactory.CreateGlobe(),
            ItemFactory.CreateCamera(),
            ItemFactory.CreateGermanShepherd(),
            ItemFactory.CreateCollie(),
            ItemFactory.CreateHusky(),
            ItemFactory.CreateParrot(),
            ItemFactory.CreateMaineCoon(),
            ItemFactory.CreatePowerArmor()
        };

        return itemPool;
    }

    private List<Threat> CreateThreatPool()
    {
        var roomPool = new List<Threat>(18)
        {
            ThreatFactory.CreateEnergyFailure(),
            ThreatFactory.CreateFire(),
            ThreatFactory.CreateRaider(),
            ThreatFactory.CreateRaider(),
            ThreatFactory.CreateMoleRat(),
            ThreatFactory.CreateMoleRat(),
            ThreatFactory.CreateRadroach(),
            ThreatFactory.CreateRadroach(),
            ThreatFactory.CreateRadscorpion(),
            ThreatFactory.CreateRadscorpion(),
            ThreatFactory.CreateGlowingOne(),
            ThreatFactory.CreateGlowingOne(),
            ThreatFactory.CreateFeralGhoul(),
            ThreatFactory.CreateFeralGhoul(),
            ThreatFactory.CreateGlowingRadscorpion(),
            ThreatFactory.CreateGlowingRadscorpion(),
            ThreatFactory.CreateDeathclaw(),
            ThreatFactory.CreateGlowingRadroach()
        };

        return roomPool;
    }
}