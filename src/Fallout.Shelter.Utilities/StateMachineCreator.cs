using Fallout.Shelter.Core.Enums;
using Stateless;

namespace Fallout.Shelter.Utilities;

public class StateMachineCreator
{
    public static StateMachine<GameState, GameTrigger> CreateAndConfigureStateMachine()
    {
        var stateMachine = new StateMachine<GameState, GameTrigger>(GameState.Initialization);

        stateMachine.Configure(GameState.Initialization)
                    .Permit(GameTrigger.Initialized, GameState.RoundStarting);

        stateMachine.Configure(GameState.RoundStarting)
                    .Permit(GameTrigger.RoundStarted, GameState.SpawningThreats);

        stateMachine.Configure(GameState.SpawningThreats)
                    .Permit(GameTrigger.ThreatsSpawned, GameState.PlacingDwellers);

        stateMachine.Configure(GameState.PlacingDwellers)
                    .Permit(GameTrigger.DwellersPlaced, GameState.RecallingDwellers);

        stateMachine.Configure(GameState.RecallingDwellers)
                    .Permit(GameTrigger.DwellersRecalled, GameState.RoundEnding);

        stateMachine.Configure(GameState.RoundEnding)
                    .Permit(GameTrigger.RoundEnded, GameState.RoundStarting);

        stateMachine.Configure(GameState.RoundEnding)
                    .Permit(GameTrigger.Finished, GameState.Finished);

        return stateMachine;
    }
}