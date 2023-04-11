using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public class GameFieldFactory : IGameFieldFactory
{
    private readonly IBuildingFactory _buildingFactory;

    public GameFieldFactory(IBuildingFactory buildingFactory)
    {
        _buildingFactory = buildingFactory;
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
                [0, 0] = _buildingFactory.CreateWasteland(),
                [0, 1] = _buildingFactory.CreateVaultDoor(),
                [0, 2] = _buildingFactory.CreateVaultEntrance(),
                [0, 3] = _buildingFactory.CreateDefaultElevator(),
                [0, 4] = _buildingFactory.CreateWaterTreatment(),
                [0, 5] = _buildingFactory.CreateDiner(),
                [0, 6] = _buildingFactory.CreatePowerGenerator(),
            }
        };

        for (var i = 1; i < playersCount; i++)
        {
            field.Field[i, 7] = _buildingFactory.CreatePlayerElevator();
        }

        return field;
    }
}