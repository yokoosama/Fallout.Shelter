using System.Security.Cryptography;

namespace Fallout.Shelter.Utilities;

public static class DiceRoller
{
    public static Tuple<int, int> Roll()
    {
        var firstDice = RandomNumberGenerator.GetInt32(1, 7);
        var secondDice = RandomNumberGenerator.GetInt32(1, 7);

        return new Tuple<int, int>(firstDice, secondDice);
    }
}