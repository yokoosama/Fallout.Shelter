using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Core.Models;
using FluentAssertions;

namespace Fallout.Shelter.Engine.Tests;

public class FalloutShelterEngineTests
{
    private FalloutShelterEngine _falloutShelterEngine = null!;

    [SetUp]
    public void Setup()
    {
        var players = new List<Player>
        {
            CreatePlayer(1),
            CreatePlayer(2),
            CreatePlayer(3, true),
            CreatePlayer(4),
        };

        _falloutShelterEngine = new FalloutShelterEngine(players);
    }

    private static Player CreatePlayer(int id, bool isFirstPlayer = false)
    {
        return new Player(id, PlayerColor.Blue)
        {
            Id = id,
            IsFirstPlayer = isFirstPlayer
        };
    }

    [Test]
    public void CreateEngine_CorrectState()
    {
        _falloutShelterEngine.GameState.Should().Be(GameState.Initialization);
        _falloutShelterEngine.Round.Should().Be(0);
        _falloutShelterEngine.Players.Should().HaveCount(4);
    }

    [Test]
    public void StartGame_CorrectState()
    {
        _falloutShelterEngine.StartGame();
        _falloutShelterEngine.GameState.Should().Be(GameState.RoundStarting);
    }

    [Test]
    public void StartGame_GameAlreadyStarted_ThrowsException()
    {
        _falloutShelterEngine.StartGame();

        var action = new Action(() => _falloutShelterEngine.StartGame());

        action.Should().Throw<InvalidOperationException>()
              .WithMessage("Cannot start game when game is not in Initialization state");
    }

    [Test]
    public void StartRound_GameNotStarted_ThrowsException()
    {
        var action = new Action(() => _falloutShelterEngine.StartRound());

        action.Should().Throw<InvalidOperationException>()
              .WithMessage("Cannot start round when game is not in RoundStarting state");
    }

    [Test]
    public void StartRound_GameStarted_RoundStarted()
    {
        _falloutShelterEngine.StartGame();
        _falloutShelterEngine.StartRound();

        _falloutShelterEngine.GameState.Should().Be(GameState.SpawningThreats);
        _falloutShelterEngine.Round.Should().Be(1);
    }

    [Test]
    public void StartRound_GameAndRoundStarted_ThrowsException()
    {
        _falloutShelterEngine.StartGame();
        _falloutShelterEngine.StartRound();

        var action = new Action(() => _falloutShelterEngine.StartRound());

        action.Should().Throw<InvalidOperationException>()
              .WithMessage("Cannot start round when game is not in RoundStarting state");
    }

    [Test]
    public void SpawnThreats_GameNotStarted_ThrowsException()
    {
        var action = new Action(() => _falloutShelterEngine.SpawnThreats());

        action.Should().Throw<InvalidOperationException>()
              .WithMessage("Cannot spawn threats when game is not in SpawningThreats state");
    }

    [Test]
    public void SpawnThreats_RoundStarted_ThreatsSpawned()
    {
        _falloutShelterEngine.StartGame();
        _falloutShelterEngine.StartRound();
        _falloutShelterEngine.SpawnThreats();

        _falloutShelterEngine.GameState.Should().Be(GameState.PlacingDwellers);
        _falloutShelterEngine.Round.Should().Be(1);
    }

    [Test]
    public void SpawnThreats_ThreatsSpawned_ThrowsException()
    {
        _falloutShelterEngine.StartGame();
        _falloutShelterEngine.StartRound();
        _falloutShelterEngine.SpawnThreats();

        var action = new Action(() => _falloutShelterEngine.SpawnThreats());

        action.Should().Throw<InvalidOperationException>()
              .WithMessage("Cannot spawn threats when game is not in SpawningThreats state");
    }
}