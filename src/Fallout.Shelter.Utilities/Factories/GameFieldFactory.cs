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
            Field =
            {
                [0, 0] = _roomFactory.CreateWasteland(),
                [0, 1] = _roomFactory.CreateVaultDoor(),
                [0, 2] = _roomFactory.CreateVaultEntrance(),
                [0, 3] = _roomFactory.CreateDefaultElevator(),
                [0, 4] = _roomFactory.CreateWaterTreatment(),
                [0, 5] = _roomFactory.CreateDiner(),
                [0, 6] = _roomFactory.CreatePowerGenerator(),
            }
        };

        for (var i = 1; i < playersCount; i++)
        {
            field.Field[i, 7] = _roomFactory.CreatePlayerElevator();
        }

        return field;
    }
}