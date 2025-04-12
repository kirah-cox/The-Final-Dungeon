using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class SlimeWeapon : Weapons
    {
        public LevelOneSlimeWeapons Weapon { get; set; }

        public SlimeWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelOneSlimeWeapons.SlimyDagger;
                    Name = "SlimyDagger";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 5;
                    break;
                case 2:
                    Weapon = LevelOneSlimeWeapons.OrbofSlime;
                    Name = "OrbofSlime";
                    StrenthRequirement = 1;
                    ManaRequirement = 5;
                    LuckRequirement = 1;
                    break;
                case 3:
                    Weapon = LevelOneSlimeWeapons.WigglyLongSword;
                    Name = "WigglyLongSword";
                    StrenthRequirement = 5;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
