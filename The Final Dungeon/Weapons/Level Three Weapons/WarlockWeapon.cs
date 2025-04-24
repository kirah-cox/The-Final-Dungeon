using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class WarlockWeapon : Weapons
    {
        public LevelThreeWarlockWeapons Weapon { get; set; }

        public WarlockWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelThreeWarlockWeapons.DarkDagger;
                    Name = "Dark Dagger";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 15;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 4;
                    break;
                case 2:
                    Weapon = LevelThreeWarlockWeapons.OrbofSouls;
                    Name = "Orb of Souls";
                    StrenthRequirement = 1;
                    ManaRequirement = 15;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 4;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelThreeWarlockWeapons.SwordofPower;
                    Name = "Sword of Power";
                    StrenthRequirement = 15;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 4;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
