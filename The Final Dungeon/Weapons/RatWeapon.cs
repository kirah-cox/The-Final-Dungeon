using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class RatWeapon : Weapons
    {
        public LevelOneRatWeapons Weapon { get; set; }

        public RatWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelOneRatWeapons.KnawedKnife;
                    Name = "Knawed Knife";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 5;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1.5;
                    break;
                case 2:
                    Weapon = LevelOneRatWeapons.TailStaff;
                    Name = "Tail Staff";
                    StrenthRequirement = 1;
                    ManaRequirement = 5;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelOneRatWeapons.HairyAxe;
                    Name = "Hairy Axe";
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
