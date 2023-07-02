namespace Fallout.Shelter.Utilities.Extensions;

public static class ListExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        var random = new Random();

        for(var i= list.Count - 1; i > 1; i--)
        {
            var rnd = random.Next(i + 1);

            (list[rnd], list[i]) = (list[i], list[rnd]);
        }
    }
}