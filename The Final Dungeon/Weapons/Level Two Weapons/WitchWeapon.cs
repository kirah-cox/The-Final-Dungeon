using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class WitchWeapon : Weapons
    {
        public LevelTwoWitchWeapons Weapon { get; set; }

        public WitchWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelTwoWitchWeapons.PoisonKnife;
                    Name = "Poison Knife";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 8;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 3;
                    break;
                case 2:
                    Weapon = LevelTwoWitchWeapons.DarkStaff;
                    Name = "Dark Staff";
                    StrenthRequirement = 1;
                    ManaRequirement = 8;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 3;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelTwoWitchWeapons.BrewingAxe;
                    Name = "Brewing Axe";
                    StrenthRequirement = 8;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 3;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
