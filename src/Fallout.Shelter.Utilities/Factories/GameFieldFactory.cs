using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public class GameFieldFactory : IGameFieldFactory
{
    private readonly IRoomFactory _roomFactory;

    public GameFieldFactory(IRoomFactory roomFactory)
    {
        _roomFactory = roomFactory;
    }

    public GameField CreateGameField(int playersCount)
    {
        if (playersCount is > 4 or < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(playersCount), "Maximum players count is 4 and minimum is 2");
        }

        var field = new GameField(playersCount)
        {
            Field = CreateDefaultRooms(playersCount),
            RoomPool = CreateRoomPool()
        };

        return field;
    }

    private Room[,] CreateDefaultRooms(int playersCount)
    {
        var field = new Room[playersCount + 1, 7];
        field[0, 0] = _roomFactory.CreateWasteland();
        field[0, 1] = _roomFactory.CreateVaultDoor();
        field[0, 2] = _roomFactory.CreateVaultEntrance();
        field[0, 3] = _roomFactory.CreateDefaultElevator();
        field[0, 4] = _roomFactory.CreateWaterTreatment();
        field[0, 5] = _roomFactory.CreateDiner();
        field[0, 6] = _roomFactory.CreatePowerGenerator();

        for (var i = 1; i < playersCount; i++)
        {
            field[i, 7] = _roomFactory.CreatePlayerElevator();
        }

        return field;
    }

    private List<Room> CreateRoomPool()
    {
        var roomPool = new List<Room>(30)
        {
            _roomFactory.CreateWaterPurificationRoom(),
            _roomFactory.CreateWaterPurificationRoom(),
            _roomFactory.CreateNukaColaBottler(),
            _roomFactory.CreateNukaColaBottler(),
            _roomFactory.CreateNuclearReactor(),
            _roomFactory.CreateNuclearReactor(),
            _roomFactory.CreateGarden(),
            _roomFactory.CreateGarden(),
            _roomFactory.CreateClassroom(),
            _roomFactory.CreateAthleticsRoom(),
            _roomFactory.CreateArmory(),
            _roomFactory.CreateGameRoom(),
            _roomFactory.CreateWeightRoom(),
            _roomFactory.CreateFitnessRoom(),
            _roomFactory.CreateStorageRoom(),
            _roomFactory.CreateLoungeRoom(),
            _roomFactory.CreateMedbayRoom(),
            _roomFactory.CreateScienceLabRoom(),
            _roomFactory.CreateRadioStudioRoom(),
            _roomFactory.CreateLivingRoom(),
            _roomFactory.CreateLivingRoom(),
            _roomFactory.CreateThemeWorkshopRoom(),
            _roomFactory.CreateOutfitWorkshopRoom(),
            _roomFactory.CreateWeaponWorkshopRoom()
        };

        return roomPool;
    }
}