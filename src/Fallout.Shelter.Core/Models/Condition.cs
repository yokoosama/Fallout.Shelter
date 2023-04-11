namespace Fallout.Shelter.Core.Models;

public class Condition
{
    public ResourceType? ResourceType { get; set; }
    public int? ResourceAmount { get; set; }
    public bool Item { get; set; }
    public bool Build { get; set; }
    public bool InjureDweller { get; set; }
    public int? Roll { get; set; }
}