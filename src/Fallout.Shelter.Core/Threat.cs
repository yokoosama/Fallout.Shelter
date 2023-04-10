namespace Fallout.Shelter.Core;

public class Threat
{
    public int Roll { get; set; }
    public Space[] Spaces { get; set; }
    public List<Reward> Rewards { get; set; }
    
    public Threat()
    {
        Spaces = new Space[2];
        Rewards = new List<Reward>(2);
    }
}