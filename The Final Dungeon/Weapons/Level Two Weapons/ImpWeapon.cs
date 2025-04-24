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
                    LuckRequirement = 7;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 2.1;
                    break;
                case 2:
                    Weapon = LevelTwoImpWeapons.GlowingOrb;
                    Name = "Glowing Orb";
                    StrenthRequirement = 1;
                    ManaRequirement = 7;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 2.1;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelTwoImpWeapons.HellSpear;
                    Name = "Hell Spear";
                    StrenthRequirement = 7;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 2.1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
