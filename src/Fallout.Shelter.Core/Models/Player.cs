using Fallout.Shelter.Core.Enums;

namespace Fallout.Shelter.Core.Models;

public class Player
{
    public int Id { get; set; }
    public bool IsFirstPlayer { get; set; }
    public PlayerColor Color { get; set; }
    public List<Resource> Resources { get; set; }
    public int Happiness { get; set; }
    public Dweller[] Dwellers { get; set; }

    public Player(int id, PlayerColor playerColor)
    {
        Id = id;
        Dwellers = new Dweller[7];
        Dwellers[0] = new Dweller(id);
        Dwellers[1] = new Dweller(id);
        Color = playerColor;

        Resources = new List<Resource>(3)
        {
            new(ResourceType.Water, 0),
            new(ResourceType.Food, 0),
            new(ResourceType.Energy, 0)
        };
    }
}