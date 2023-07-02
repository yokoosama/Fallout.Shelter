using Fallout.Shelter.Core.Models;
using Fallout.Shelter.Utilities.Factories;

namespace Fallout.Shelter.Engine;

public class FalloutShelterEngine
{
    public List<Player> Players { get; }
    public GameField GameField { get; }

    public FalloutShelterEngine(List<Player> players, IGameFieldFactory gameFieldFactory)
    {
        GameField = gameFieldFactory.CreateGameField(players.Count);
        Players = players;
    }
}