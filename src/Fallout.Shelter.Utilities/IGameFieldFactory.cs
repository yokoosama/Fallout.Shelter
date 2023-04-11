using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities;

public interface IGameFieldFactory
{
    GameField CreateGameField(int playersCount);
}