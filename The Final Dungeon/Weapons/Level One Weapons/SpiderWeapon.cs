using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class SpiderWeapon : Weapons
    {
        public LevelOneSpiderWeapons Weapon { get; set; }

        public SpiderWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelOneSpiderWeapons.PincerKnife;
                    Name = "Pincer Knife";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 5;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1.7;
                    break;
                case 2:
                    Weapon = LevelOneSpiderWeapons.OrbofManyEyes;
                    Name = "Orb of Many Eyes";
                    StrenthRequirement = 1;
                    ManaRequirement = 5;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1.7;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelOneSpiderWeapons.WebbedHammer;
                    Name = "Webbed Hammer";
                    StrenthRequirement = 5;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1.7;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
