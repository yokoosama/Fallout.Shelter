using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Core.Models;
using Fallout.Shelter.Utilities.Factories;
using Stateless;

namespace Fallout.Shelter.Engine;

public class FalloutShelterEngine
{
    public List<Player> Players { get; }
    public GameField GameField { get; }
    private Queue<Player> PlayersQueue { get; set; }
    public int Round { get; set; }

    private readonly StateMachine<GameState, GameTrigger> _stateMachine;

    public FalloutShelterEngine(List<Player> players)
    {
        var factory = new GameFieldFactory();
        GameField = factory.CreateGameField(players.Count);
        Players = players;
        PlayersQueue = new Queue<Player>(players);
        _stateMachine = CreateAndConfigureStateMachine();
        _stateMachine.Fire(GameTrigger.Initialized);
    }

    private static StateMachine<GameState, GameTrigger> CreateAndConfigureStateMachine()
    {
        var stateMachine = new StateMachine<GameState, GameTrigger>(GameState.Initialization);

        stateMachine.Configure(GameState.Initialization)
                    .Permit(GameTrigger.Initialized, GameState.SpawnThreats);

        stateMachine.Configure(GameState.SpawnThreats)
                    .Permit(GameTrigger.ThreatsSpawned, GameState.PlaceDwellers);

        stateMachine.Configure(GameState.PlaceDwellers)
                    .Permit(GameTrigger.DwellersPlaced, GameState.RecallDwellers);

        stateMachine.Configure(GameState.RecallDwellers)
                    .Permit(GameTrigger.DwellersRecalled, GameState.SpawnThreats);

        stateMachine.Configure(GameState.RecallDwellers)
                    .Permit(GameTrigger.Finished, GameState.Finished);

        return stateMachine;
    }
}