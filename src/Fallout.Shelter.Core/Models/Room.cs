using Fallout.Shelter.Core.Enums;

namespace Fallout.Shelter.Core.Models;

public class Room
{
    public string Name { get; set; }
    public bool IsElevator { get; set; }
    public Dictionary<ResourceType, int> Price { get; set; }
    public RoomSector[] Sectors { get; set; }

    public Room(string name, bool isElevator = false)
    {
        Name = name;
        IsElevator = isElevator;
        Price = new Dictionary<ResourceType, int>();
        Sectors = new RoomSector[isElevator ? 1 : 2];
    }
}