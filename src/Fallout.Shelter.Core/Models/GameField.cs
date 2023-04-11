namespace Fallout.Shelter.Core.Models;

public class GameField
{
    public Room[,] Field { get; set; }
    public List<Room> RoomPool { get; set; }
    public List<Item> ItemPool { get; set; }
    public List<Threat> ThreatPool { get; set; }
    public List<Room> DiscardedRooms { get; set; }
    public List<Item> DiscardedItems { get; set; }
    public List<Threat> DiscardedThreats { get; set; }

    public GameField(int playersCount)
    {
        if (playersCount is > 4 or < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(playersCount), "Maximum players count is 4 and minimum is 2");
        }

        Field = new Room[playersCount + 1, 7];
        RoomPool = new List<Room>(30);
        ItemPool = new List<Item>(31);
        ThreatPool = new List<Threat>(18);
        DiscardedRooms = new List<Room>(30);
        DiscardedItems = new List<Item>(31);
        DiscardedThreats = new List<Threat>(18);
    }
}