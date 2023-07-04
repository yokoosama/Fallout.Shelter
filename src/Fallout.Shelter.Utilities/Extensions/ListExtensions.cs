namespace Fallout.Shelter.Utilities.Extensions;

public static class ListExtensions
{
    public static IList<T> Shuffle<T>(this IList<T> list)
    {
        var random = new Random();

        for(var i= list.Count - 1; i > 1; i--)
        {
            var rnd = random.Next(i + 1);

            (list[rnd], list[i]) = (list[i], list[rnd]);
        }

        return list;
    }

    public static Stack<T> ToStack<T>(this IList<T> list)
    {
        var stack = new Stack<T>(list.Count);

        foreach (var element in list)
        {
            stack.Push(element);
        }

        return stack;
    }
}