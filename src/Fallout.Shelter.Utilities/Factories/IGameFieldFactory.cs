using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public interface IGameFieldFactory
{
    GameField CreateGameField(int playersCount);
}