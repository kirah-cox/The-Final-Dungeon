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
                    LuckRequirement = 12;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 4.5;
                    break;
                case 2:
                    Weapon = LevelThreeEvilEntWeapons.BranchStaff;
                    Name = "Branch Staff";
                    StrenthRequirement = 1;
                    ManaRequirement = 12;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 4.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelThreeEvilEntWeapons.OvergrownSword;
                    Name = "Overgrown Sword";
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
