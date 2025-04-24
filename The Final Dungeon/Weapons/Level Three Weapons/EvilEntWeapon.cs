using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LootThings.Weapons;

namespace LootThings
{
    public class EvilEntWeapon : Weapons
    {
        public LevelThreeEvilEntWeapons Weapon { get; set; }

        public EvilEntWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelThreeEvilEntWeapons.MossyDagger;
                    Name = "Mossy Dagger";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 14;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 3.7;
                    break;
                case 2:
                    Weapon = LevelThreeEvilEntWeapons.BranchStaff;
                    Name = "Branch Staff";
                    StrenthRequirement = 1;
                    ManaRequirement = 14;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 3.7;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelThreeEvilEntWeapons.OvergrownSword;
                    Name = "Overgrown Sword";
                    StrenthRequirement = 14;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 3.7;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
