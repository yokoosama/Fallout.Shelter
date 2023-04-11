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
    }
}