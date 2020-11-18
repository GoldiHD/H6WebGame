using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity
{
    public class Enemy
    {
        public int EnemyID { get; set; }
        public string EnemyName { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int MaxLoot { get; set; }
        public int MinLoot { get; set; }
    }
}
