using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public static class ThreatFactory
{
    public static Threat CreateGlowingRadroach()
    {
        var threat = new Threat("Glowing Radroach")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Endurance,
                }
            },
            Roll = 6
        };

        return threat;
    }
    
    public static Threat CreateDeathclaw()
    {
        var threat = new Threat("Deathclaw", 2)
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(2)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Endurance,
                },
                [1] = new Space()
            },
            Roll = 9
        };

        return threat;
    }
    
    public static Threat CreateGlowingRadscorpion()
    {
        var threat = new Threat("Glowing Radscorpion")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
                RewardFactory.CreateWithResources(ResourceType.Random, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Endurance,
                }
            },
            Roll = 9
        };

        return threat;
    }
    
    public static Threat CreateFeralGhoul()
    {
        var threat = new Threat("Feral Ghoul")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Intelligence,
                }
            },
            Roll = 7
        };

        return threat;
    }
    
    public static Threat CreateGlowingOne()
    {
        var threat = new Threat("Glowing One")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Endurance,
                }
            },
            Roll = 8
        };

        return threat;
    }
    
    public static Threat CreateRadscorpion()
    {
        var threat = new Threat("Radscorpion")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
                RewardFactory.CreateWithResources(ResourceType.Random, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Perception,
                }
            },
            Roll = 8
        };

        return threat;
    }
    
    public static Threat CreateRadroach()
    {
        var threat = new Threat("Radroach")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithResources(ResourceType.Random, 1)
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Agility,
                }
            },
            Roll = 5
        };

        return threat;
    }
    
    public static Threat CreateMoleRat()
    {
        var threat = new Threat("Mole Rat")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Strength,
                }
            },
            Roll = 6
        };

        return threat;
    }
    
    public static Threat CreateRaider()
    {
        var threat = new Threat("Raider")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithItem()
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Charisma,
                }
            },
            Roll = 9
        };

        return threat;
    }
    
    public static Threat CreateFire()
    {
        var threat = new Threat("Fire")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Endurance,
                }
            },
            Resource = new Resource(ResourceType.Water, 1)
        };

        return threat;
    }
    
    public static Threat CreateEnergyFailure()
    {
        var threat = new Threat("Energy Failure")
        {
            Rewards = new List<Reward>
            {
                RewardFactory.CreateWithHappiness(1),
            },
            Spaces =
            {
                [0] = new Space
                {
                    SpecialStat = SpecialStat.Intelligence,
                }
            },
            Resource = new Resource(ResourceType.Energy, 2)
        };

        return threat;
    }
}