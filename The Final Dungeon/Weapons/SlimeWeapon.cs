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
                    Name = "Slimy Dagger";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 5;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1.5;
                    break;
                case 2:
                    Weapon = LevelOneSlimeWeapons.OrbofSlime;
                    Name = "Orb of Slime";
                    StrenthRequirement = 1;
                    ManaRequirement = 5;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelOneSlimeWeapons.WigglyLongSword;
                    Name = "Wiggly Long Sword";
                    StrenthRequirement = 5;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1.5;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
