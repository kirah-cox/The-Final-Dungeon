using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Final_Dungeon
{
    class Loot
    {
        public Dictionary<PotionType, int> PotionsContained = new Dictionary<PotionType, int>();
        public enum PotionType
        {
            Health,
            Strength,
            Mana,
            Luck,
        }

        public enum WeaponType
        {

        }
    }
}
