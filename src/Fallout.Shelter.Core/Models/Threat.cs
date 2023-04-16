namespace Fallout.Shelter.Core.Models;

public class Threat
{
    public string Name { get; set; }
    public List<Reward> Rewards { get; set; }
    public Space[] Spaces { get; set; }
    public int? Roll { get; set; }
    public Resource? Resource { get; set; }

    public Threat(string name, int spacesCount = 1)
    {
        Name = name;
        Spaces = new Space[spacesCount];
        Rewards = new List<Reward>(2);
    }
}