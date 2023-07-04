namespace Fallout.Shelter.Core.Models;

public class GameField
{
    public Room[,] Field { get; set; }
    public Stack<Room> RoomPool { get; set; }
    public Stack<Item> ItemPool { get; set; }
    public Stack<Threat> ThreatPool { get; set; }
    public Stack<Room> DiscardedRooms { get; set; }
    public Stack<Item> DiscardedItems { get; set; }
    public Stack<Threat> DiscardedThreats { get; set; }

    public GameField(int playersCount)
    {
        if (playersCount is > 4 or < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(playersCount), "Maximum players count is 4 and minimum is 2");
        }

        Field = new Room[playersCount + 1, 7];
        RoomPool = new Stack<Room>(30);
        ItemPool = new Stack<Item>(31);
        ThreatPool = new Stack<Threat>(18);
        DiscardedRooms = new Stack<Room>(30);
        DiscardedItems = new Stack<Item>(31);
        DiscardedThreats = new Stack<Threat>(18);
    }
}