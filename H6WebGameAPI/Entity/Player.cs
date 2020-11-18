using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity
{
    public class Player
    {
        public int userID { get; set; }
        public int Xcord { get; set; }
        public int Ycord { get; set; }
        public string PlayerName { get; set; }
        public int CurrentXP { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public PlayerClass myClass { get; set; }
        public PlayerRace myRace { get; set; }
        public PlayerInventory myInventory { get; set; }
        public PlayerStats myStats { get; set; }
    }
}
