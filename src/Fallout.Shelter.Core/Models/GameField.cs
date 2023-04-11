namespace Fallout.Shelter.Core.Models;

public class GameField
{
    public Building[,] Field { get; set; }

    public GameField(int playersCount)
    {
        if (playersCount is > 4 or < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(playersCount), "Maximum players count is 4 and minimum is 2");
        }

        Field = new Building[playersCount + 1, 7];
        Field[0, 0] = new Building("The Wasteland");
        Field[0, 1] = new Building("Vault Door");
        Field[0, 2] = new Building("Vault Entrance");
        Field[0, 3] = new Building("Elevator",true);
        Field[0, 4] = new Building("Water Treatment");
        Field[0, 5] = new Building("Diner");
        Field[0, 6] = new Building("Power Generator");

        for (var i = 1; i < playersCount; i++)
        {
            Field[i, 7] = new Building("Elevator",true);
        }
    }
}