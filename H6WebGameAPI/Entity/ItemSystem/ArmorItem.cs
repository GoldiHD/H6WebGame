using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity.ItemSystem
{
    public class ArmorItem : BaseItem
    {
        public int ArmorID { get; set; }
        public int ArmorSlot { get; set; }
        public int ArmorIncrease { get; set; }
    }
}
