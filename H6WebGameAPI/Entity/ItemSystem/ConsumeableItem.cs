using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity.ItemSystem
{
    public class ConsumeableItem : BaseItem
    {
        public int ConsumableID { get; set; }
        public ConsumeAbleType ConsumeAbleType { get; set; }
    }
}
