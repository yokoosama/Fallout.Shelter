using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Core.Models;
using Fallout.Shelter.Utilities;
using Fallout.Shelter.Utilities.Factories;
using Stateless;

namespace Fallout.Shelter.Engine;

public class FalloutShelterEngine
{
    public List<Player> Players { get; }
    public GameField GameField { get; }
    private Queue<Player> PlayersQueue { get; }
    public int Round { get; private set; }
    public GameState GameState => _stateMachine.State;

    private readonly StateMachine<GameState, GameTrigger> _stateMachine;
    private StateMachine<GameState, GameTrigger>.TriggerWithParameters<FalloutShelterEngine> _spawnThreatsTrigger;

    public FalloutShelterEngine(List<Player> players)
    {
        ValidatePlayers(players);
        Players = players;
        PlayersQueue = new Queue<Player>();
        GameField = GameFieldFactory.CreateGameField(players.Count);
        _stateMachine = StateMachineCreator.CreateAndConfigureStateMachine();
        _spawnThreatsTrigger = _stateMachine.SetTriggerParameters<FalloutShelterEngine>(GameTrigger.Initialized);
    }

    public void StartGame()
    {
        if (_stateMachine.State != GameState.Initialization)
        {
            throw new InvalidOperationException("Cannot start game when game is not in Initialization state");
        }

        _stateMachine.Fire(GameTrigger.Initialized);
        _stateMachine.Fire(GameTrigger.GameStarted);
    }

    public void StartRound()
    {
        if (_stateMachine.State != GameState.RoundStarting && _stateMachine.State != GameState.GameStarting)
        {
            throw new InvalidOperationException("Cannot start round when game is not in RoundStarting state");
        }

        Round++;
        var firstPlayer = Players.First(x => x.IsFirstPlayer);
        PlayersQueue.Enqueue(firstPlayer);
        var firstPlayerIndex = Players.IndexOf(firstPlayer);

        for (var i = firstPlayerIndex + 1; i < Players.Count; i++)
        {
            PlayersQueue.Enqueue(Players[i]);
        }

        for (var i = 0; i < firstPlayerIndex; i++)
        {
            PlayersQueue.Enqueue(Players[i]);
        }

        _stateMachine.Fire(GameTrigger.RoundStarted);
    }

    public void SpawnThreats()
    {
        if (_stateMachine.State != GameState.SpawningThreats)
        {
            throw new InvalidOperationException("Cannot spawn threats when game is not in SpawningThreats state");
        }

        for (var i = 0; i < Players.Count + 1; i++)
        {
            var diceSum = DiceRoller.RollSum();
            var roomIndex = diceSum / 2;
            var room = GameField.Field[i, roomIndex];

            if (room == null)
            {
                continue;
            }

            if (room.IsElevator)
            {
                continue;
            }

            var sectorIndex = (diceSum + 1) % 2;
            var roomSector = room.Sectors[sectorIndex];

            if (roomSector.Threat is not null)
            {
                continue;
            }

            roomSector.Threat = GameField.GetThreat();
        }

        _stateMachine.Fire(GameTrigger.ThreatsSpawned);
    }

    private static void ValidatePlayers(List<Player> players)
    {
        if (players.Select(x=>x.Id).Distinct().Count() != players.Count)
        {
            throw new ArgumentException("Players must have unique ids");
        }
    }
}