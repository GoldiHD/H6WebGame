using H6WebGameAPI.Entity.ItemSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity
{
    public class Tile
    {
        public string name { get; set; }
        public string description { get; set; }
        public int Xcord { get; set; }
        public int ycord { get; set; }
        public List<Enemy> enemies { get; set; }
        public List<BaseItem> baseItems { get; set; }
        public string imageName { get; set; }
    }
}
