using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Utilities.Factories;

namespace Fallout.Shelter.Utilities.Tests;

public class ItemFactoryTests
{
    [Test]
    public void CreateGoldenRetriever_CreateValidReward()
    {
        var reward = ItemFactory.CreateGoldenRetriever();

        reward.Name.Should().Be("Golden Retriever");
        reward.Type.Should().Be(ItemType.Pet);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeTrue();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().BeNull();
    }

    [Test]
    public void CreateStimpak_CreateValidReward()
    {
        var reward = ItemFactory.CreateStimpak();

        reward.Name.Should().Be("Stimpak");
        reward.Type.Should().Be(ItemType.Other);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeTrue();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().BeNull();
    }

    [Test]
    public void CreateShotgun_CreateValidReward()
    {
        var reward = ItemFactory.CreateShotgun();

        reward.Name.Should().Be("Shotgun");
        reward.Type.Should().Be(ItemType.Weapon);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().Be(2);
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().BeNull();
    }

    [Test]
    public void CreateLaserRifle_CreateValidReward()
    {
        var reward = ItemFactory.CreateLaserRifle();

        reward.Name.Should().Be("Laser Rifle");
        reward.Type.Should().Be(ItemType.Weapon);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().Be(2);
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().BeNull();
    }

    [Test]
    public void CreatePlasmaPistol_CreateValidReward()
    {
        var reward = ItemFactory.CreatePlasmaPistol();

        reward.Name.Should().Be("Plasma Pistol");
        reward.Type.Should().Be(ItemType.Weapon);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().Be(2);
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().BeNull();
    }

    [Test]
    public void CreateMinigun_CreateValidReward()
    {
        var reward = ItemFactory.CreateMinigun();

        reward.Name.Should().Be("Minigun");
        reward.Type.Should().Be(ItemType.Weapon);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().Be(3);
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().BeNull();
    }

    [Test]
    public void CreatePistol_CreateValidReward()
    {
        var reward = ItemFactory.CreatePistol();

        reward.Name.Should().Be("10mm Pistol");
        reward.Type.Should().Be(ItemType.Weapon);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeTrue();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().Be(1);
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().BeNull();
    }

    [Test]
    public void CreateWastelandGear_CreateValidReward()
    {
        var reward = ItemFactory.CreateWastelandGear();
    
        reward.Name.Should().Be("Wasteland Gear");
        reward.Type.Should().Be(ItemType.Armor);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().Be(SpecialStat.Endurance);
    }

    [Test]
    public void CreateNightwear_CreateValidReward()
    {
        var reward = ItemFactory.CreateNightwear();
    
        reward.Name.Should().Be("Nightwear");
        reward.Type.Should().Be(ItemType.Armor);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().Be(SpecialStat.Charisma);
    }

    [Test]
    public void CreateFormalWear_CreateValidReward()
    {
        var reward = ItemFactory.CreateFormalWear();
    
        reward.Name.Should().Be("Formal Wear");
        reward.Type.Should().Be(ItemType.Armor);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().Be(SpecialStat.Luck);
    }

    [Test]
    public void CreateMilitaryFatigues_CreateValidReward()
    {
        var reward = ItemFactory.CreateMilitaryFatigues();
    
        reward.Name.Should().Be("Military Fatigues");
        reward.Type.Should().Be(ItemType.Armor);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().Be(SpecialStat.Strength);
    }

    [Test]
    public void CreateHandymanJumpsuit_CreateValidReward()
    {
        var reward = ItemFactory.CreateHandymanJumpsuit();
    
        reward.Name.Should().Be("Handyman Jumpsuit");
        reward.Type.Should().Be(ItemType.Armor);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().Be(SpecialStat.Agility);
    }

    [Test]
    public void CreateArmoredVaultSuit_CreateValidReward()
    {
        var reward = ItemFactory.CreateArmoredVaultSuit();
    
        reward.Name.Should().Be("Armored Vault Suit");
        reward.Type.Should().Be(ItemType.Armor);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().Be(SpecialStat.Perception);
    }

    [Test]
    public void CreateLabCoat_CreateValidReward()
    {
        var reward = ItemFactory.CreateLabCoat();
    
        reward.Name.Should().Be("Lab Coat");
        reward.Type.Should().Be(ItemType.Armor);
        reward.IsActive.Should().BeTrue();
        reward.IsAlwaysActive.Should().BeFalse();
        reward.IsEndGameItem.Should().BeFalse();
        reward.GiveActivateItemPossibility.Should().BeFalse();
        reward.GiveAdditionalDamage.Should().BeNull();
        reward.GiveReRollPossibility.Should().BeFalse();
        reward.HealDweller.Should().BeFalse();
        reward.GiveHappinessPerItem.Should().BeNull();
        reward.GiveHappinessPerResources.Should().BeNull();
        reward.GiveHappinessPerDwellers.Should().BeFalse();
        reward.GiveHappinessPerRooms.Should().BeFalse();
        reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
        reward.GiveItemChangePossibility.Should().BeFalse();
        reward.GiveResourceExchange.Should().BeFalse();
        reward.GiveNeededStatInFight.Should().BeNull();
        reward.ExchangeFrom.Should().BeNull();
        reward.ExchangeTo.Should().BeNull();
        reward.GiveSpecialStatToDweller.Should().Be(SpecialStat.Intelligence);
    }
    
    // [Test]
    // public void CreateGoldenRetriever_CreateValidReward()
    // {
    //     var reward = ItemFactory.CreateGoldenRetriever();
    //
    //     reward.Name.Should().Be("Golden Retriever");
    //     reward.Type.Should().Be(ItemType.Pet);
    //     reward.IsActive.Should().BeTrue();
    //     reward.IsAlwaysActive.Should().BeFalse();
    //     reward.IsEndGameItem.Should().BeFalse();
    //     reward.GiveActivateItemPossibility.Should().BeFalse();
    //     reward.GiveAdditionalDamage.Should().BeNull();
    //     reward.GiveReRollPossibility.Should().BeFalse();
    //     reward.HealDweller.Should().BeFalse();
    //     reward.GiveHappinessPerItem.Should().BeNull();
    //     reward.GiveHappinessPerResources.Should().BeNull();
    //     reward.GiveHappinessPerDwellers.Should().BeFalse();
    //     reward.GiveHappinessPerRooms.Should().BeFalse();
    //     reward.GiveAdditionalResourceForBuilding.Should().BeFalse();
    //     reward.GiveItemChangePossibility.Should().BeFalse();
    //     reward.GiveResourceExchange.Should().BeFalse();
    //     reward.GiveNeededStatInFight.Should().BeNull();
    //     reward.ExchangeFrom.Should().BeNull();
    //     reward.ExchangeTo.Should().BeNull();
    //     reward.GiveSpecialStatToDweller.Should().BeNull();
    // }
}