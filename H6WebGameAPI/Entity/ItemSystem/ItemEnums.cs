using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity.ItemSystem
{

    public enum ItemType
    {
        WeaponItem,
        ArmorItem,
        ConsumeableItem
    }

    public enum ConsumeAbleType
    {
        Healing,
        Arrows
    }

    public enum ArmorSlot
    {
        Head,
        Chest,
        Legs
    }

    public enum WeaponMod
    {
        Strenght,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charima
    }
}
