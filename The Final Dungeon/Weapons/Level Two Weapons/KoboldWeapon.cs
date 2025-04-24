using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class KoboldWeapon : Weapons
    {
        public LevelTwoKoboldWeapons Weapon { get; set; }

        public KoboldWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelTwoKoboldWeapons.SneakyShank;
                    Name = "Sneaky Shank";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 9;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 2.5;
                    break;
                case 2:
                    Weapon = LevelTwoKoboldWeapons.OrbofFire;
                    Name = "Orb of Fire";
                    StrenthRequirement = 1;
                    ManaRequirement = 9;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 2.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelTwoKoboldWeapons.ScalySpear;
                    Name = "Scaly Spear";
                    StrenthRequirement = 9;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 2.5;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
