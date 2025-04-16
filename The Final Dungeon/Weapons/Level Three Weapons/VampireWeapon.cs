using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class VampireWeapon : Weapons
    {
        public LevelThreeVampireWeapons Weapon { get; set; }

        public VampireWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelThreeVampireWeapons.BloodyKnife;
                    Name = "Bloody Knife";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 12;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 4.5;
                    break;
                case 2:
                    Weapon = LevelThreeVampireWeapons.FangedOrb;
                    Name = "Fanged Orb";
                    StrenthRequirement = 1;
                    ManaRequirement = 12;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 4.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelThreeVampireWeapons.DarkSlicer;
                    Name = "Dark Slicer";
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
