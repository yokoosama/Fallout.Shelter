namespace Fallout.Shelter.Core.Models;

public class RoomSector
{
    public List<Condition> PriceToSpawn { get; set; }
    public List<Reward> Rewards { get; set; }
    public Space[] Spaces { get; set; }

    public RoomSector()
    {
        PriceToSpawn = new List<Condition>();
        Rewards = new List<Reward>();
        Spaces = new Space[2];
    }
}