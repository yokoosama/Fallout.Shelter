using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Utilities.Factories;

namespace Fallout.Shelter.Utilities.Tests;

public class ThreatFactoryTests
{
    [Test]
    public void CreateGlowingRadroach_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateGlowingRadroach();

        threat.Name.Should().Be("Glowing Radroach");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Endurance,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(6);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateDeathclaw_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateDeathclaw();

        threat.Name.Should().Be("Deathclaw");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithHappiness(2));

        threat.Spaces.Should().HaveCount(2).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Endurance,
                  IsOnlyForInjuredDweller = false
              }).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = null,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(9);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateGlowingRadscorpion_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateGlowingRadscorpion();

        threat.Name.Should().Be("Glowing Radscorpion");
        
        threat.Rewards.Should().HaveCount(2).And
              .ContainInOrder(RewardFactory.CreateWithHappiness(1)).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Endurance,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(9);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateFeralGhoul_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateFeralGhoul();

        threat.Name.Should().Be("Feral Ghoul");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithHappiness(1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Intelligence,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(7);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateGlowingOne_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateGlowingOne();

        threat.Name.Should().Be("Glowing One");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithHappiness(1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Endurance,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(8);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateRadscorpion_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateRadscorpion();

        threat.Name.Should().Be("Radscorpion");
        
        threat.Rewards.Should().HaveCount(2).And
              .ContainInOrder(RewardFactory.CreateWithHappiness(1)).And
            .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Perception,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(8);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateRadroach_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateRadroach();

        threat.Name.Should().Be("Radroach");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithResources(ResourceType.Random, 1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Agility,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(5);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateMoleRat_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateMoleRat();

        threat.Name.Should().Be("Mole Rat");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithHappiness(1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Strength,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(6);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateRaider_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateRaider();

        threat.Name.Should().Be("Raider");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithItem());

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Charisma,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().Be(9);
        threat.Resource.Should().BeNull();
    }
    
    [Test]
    public void CreateFire_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateFire();

        threat.Name.Should().Be("Fire");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithHappiness(1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Endurance,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().BeNull();
        threat.Resource.Should().Be(new Resource(ResourceType.Water, 1));
    }
    
    [Test]
    public void CreateEnergyFailure_CreateValidThreat()
    {
        var threat = ThreatFactory.CreateEnergyFailure();

        threat.Name.Should().Be("Energy Failure");
        
        threat.Rewards.Should().HaveCount(1).And
              .ContainInOrder(RewardFactory.CreateWithHappiness(1));

        threat.Spaces.Should().HaveCount(1).And
              .ContainEquivalentOf(new Space
              {
                  Dweller = null,
                  SpecialStat = SpecialStat.Intelligence,
                  IsOnlyForInjuredDweller = false
              });

        threat.Roll.Should().BeNull();
        threat.Resource.Should().Be(new Resource(ResourceType.Energy, 2));
    }
}