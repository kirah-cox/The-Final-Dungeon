using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LootThings.Weapons;

namespace LootThings
{
    public class ViperWeapon : Weapons
    {
        public LevelOneViperWeapons Weapon { get; set; }

        public ViperWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelOneViperWeapons.FangedDagger;
                    Name = "Fanged Dagger";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 5;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1.5;
                    break;
                case 2:
                    Weapon = LevelOneViperWeapons.FangStaff;
                    Name = "Fang Staff";
                    StrenthRequirement = 1;
                    ManaRequirement = 5;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelOneViperWeapons.SpikedMace;
                    Name = "Spiked Mace";
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
