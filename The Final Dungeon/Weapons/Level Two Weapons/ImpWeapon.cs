using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class ImpWeapon : Weapons
    {
        public LevelTwoImpWeapons Weapon { get; set; }

        public ImpWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelTwoImpWeapons.FieryKnife;
                    Name = "Fiery Knife";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 8;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 3;
                    break;
                case 2:
                    Weapon = LevelTwoImpWeapons.GlowingOrb;
                    Name = "Glowing Orb";
                    StrenthRequirement = 1;
                    ManaRequirement = 8;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 3;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelTwoImpWeapons.HellSpear;
                    Name = "Hell Spear";
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
