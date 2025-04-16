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
                    LuckRequirement = 12;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 4.5;
                    break;
                case 2:
                    Weapon = LevelThreeWarlockWeapons.OrbofSouls;
                    Name = "Orb of Souls";
                    StrenthRequirement = 1;
                    ManaRequirement = 12;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 4.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelThreeWarlockWeapons.SwordofPower;
                    Name = "Sword of Power";
                    StrenthRequirement = 12;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 4.5;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
