using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Final_Dungeon
{
    class Potions : Loot
    {
        public Dictionary<string, int> PotionList = new Dictionary<string, int>()
        {

        };
        public int HealthGained {  get; set; }
        public int StrengthGained {  get; set; }
        public int ManaGained {  get; set; }
        public int LuckGained {  get; set; }
        
    }
}
