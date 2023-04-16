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

    public static Item CreateLabCoat()
    {
        var item = new Item("Lab Coat", ItemType.Armor)
        {
            GiveSpecialStatToDweller = SpecialStat.Intelligence
        };

        return item;
    }
}