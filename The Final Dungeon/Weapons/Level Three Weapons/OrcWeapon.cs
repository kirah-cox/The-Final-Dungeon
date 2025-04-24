using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LootThings.Weapons;

namespace LootThings
{
    public class OrcWeapon : Weapons
    {
        public LevelThreeOrcWeapons Weapon { get; set; }

        public OrcWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelThreeOrcWeapons.ThickDagger;
                    Name = "Thick Dagger";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 13;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 3.5;
                    break;
                case 2:
                    Weapon = LevelThreeOrcWeapons.OrbofBloodLust;
                    Name = "Orb of Blood Lust";
                    StrenthRequirement = 1;
                    ManaRequirement = 13;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 3.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelThreeOrcWeapons.HeavyBattleAxe;
                    Name = "Heavy Battle Axe";
                    StrenthRequirement = 13;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 3.5;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
