using Fallout.Shelter.Core.Enums;
using Fallout.Shelter.Core.Models;

namespace Fallout.Shelter.Utilities.Factories;

public static class ItemFactory
{
    public static Item CreateGoldenRetriever()
    {
        var item = new Item("Golden Retriever", ItemType.Pet)
        {
            GiveActivateItemPossibility = true
        };

        return item;
    }

    public static Item CreateStimpak()
    {
        var item = new Item("Stimpak", ItemType.Other)
        {
            HealDweller = true
        };

        return item;
    }

    public static Item CreatePistol()
    {
        var item = new Item("10mm Pistol", ItemType.Weapon)
        {
            GiveAdditionalDamage = 1,
            IsAlwaysActive = true
        };

        return item;
    }

    public static Item CreateMinigun()
    {
        var item = new Item("Minigun", ItemType.Weapon)
        {
            GiveAdditionalDamage = 3
        };

        return item;
    }

    public static Item CreatePlasmaPistol()
    {
        var item = new Item("Plasma Pistol", ItemType.Weapon)
        {
            GiveAdditionalDamage = 2
        };

        return item;
    }

    public static Item CreateLaserRifle()
    {
        var item = new Item("Laser Rifle", ItemType.Weapon)
        {
            GiveAdditionalDamage = 2
        };

        return item;
    }

    public static Item CreateShotgun()
    {
        var item = new Item("Shotgun", ItemType.Weapon)
        {
            GiveAdditionalDamage = 2
        };

        return item;
    }

    public static Item CreateWastelandGear()
    {
        var item = new Item("Wasteland Gear", ItemType.Armor)
        {
            GiveSpecialStatToDweller = SpecialStat.Endurance
        };

        return item;
    }

    public static Item CreateNightwear()
    {
        var item = new Item("Nightwear", ItemType.Armor)
        {
            GiveSpecialStatToDweller = SpecialStat.Charisma
        };

        return item;
    }

    public static Item CreateFormalWear()
    {
        var item = new Item("Formal Wear", ItemType.Armor)
        {
            GiveSpecialStatToDweller = SpecialStat.Luck
        };

        return item;
    }

    public static Item CreateMilitaryFatigues()
    {
        var item = new Item("Military Fatigues", ItemType.Armor)
        {
            GiveSpecialStatToDweller = SpecialStat.Strength
        };

        return item;
    }

    public static Item CreateHandymanJumpsuit()
    {
        var item = new Item("Handyman Jumpsuit", ItemType.Armor)
        {
            GiveSpecialStatToDweller = SpecialStat.Agility
        };

        return item;
    }

    public static Item CreateArmoredVaultSuit()
    {
        var item = new Item("Armored Vault Suit", ItemType.Armor)
        {
            GiveSpecialStatToDweller = SpecialStat.Perception
        };

        return item;
    }

    public static Item CreateLabCoat()
    {
        var item = new Item("Lab Coat", ItemType.Armor)
        {
            GiveSpecialStatToDweller = SpecialStat.Intelligence
        };

        return item;
    }

    public static Item CreateScottishFold()
    {
        var item = new Item("Scottish Fold", ItemType.Pet)
        {
            GiveReRollPossibility = true
        };

        return item;
    }

    public static Item CreateMissileLauncher()
    {
        var item = new Item("Missile Launcher", ItemType.Weapon)
        {
            GiveReRollPossibility = true
        };

        return item;
    }

    public static Item CreateFatMan()
    {
        var item = new Item("Fat Man", ItemType.Weapon)
        {
            GiveReRollPossibility = true
        };

        return item;
    }

    public static Item CreateGiddyupButtercup()
    {
        var item = new Item("Giddyup Buttercup", ItemType.Other)
        {
            GiveHappinessPerItem = ItemType.Pet
        };

        return item;
    }

    public static Item CreateYaoGuaiHide()
    {
        var item = new Item("Yao Guai Hide", ItemType.Other)
        {
            GiveHappinessPerItem = ItemType.Armor
        };

        return item;
    }

    public static Item CreateMilitaryDuctTape()
    {
        var item = new Item("Military Duct Tape", ItemType.Other)
        {
            GiveHappinessPerItem = ItemType.Weapon
        };

        return item;
    }
}