using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity.ItemSystem
{
    public class WeaponItem : BaseItem
    {
        public int WeaponID { get; set; }
        public int DamageMod { get; set; }
        public WeaponMod StatsMod { get; set; }
        public int ManaCost { get; set; }

    }
}
