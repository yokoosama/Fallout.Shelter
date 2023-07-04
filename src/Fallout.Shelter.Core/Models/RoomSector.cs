namespace Fallout.Shelter.Core.Models;

public class RoomSector
{
    public List<Condition> Conditions { get; set; }
    public List<Reward> Rewards { get; set; }
    public Space[] Spaces { get; set; }
    public Threat? Threat { get; set; }

    public RoomSector(int spaceCount = 1)
    {
        Conditions = new List<Condition>();
        Rewards = new List<Reward>();
        Spaces = new Space[spaceCount];
    }
}