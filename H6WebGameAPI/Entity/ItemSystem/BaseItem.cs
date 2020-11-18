using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity.ItemSystem
{
    public class BaseItem
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemValue { get; set; }
        public int ItemType { get; set; }
        public int EquipAble { get; set; }
        public string ItemDescription { get; set; }
    }
}
