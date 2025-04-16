using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class GoblinWeapon : Weapons
    {
        public LevelTwoGoblinWeapons Weapon { get; set; }

        public GoblinWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelTwoGoblinWeapons.GreasyShiv;
                    Name = "Greasy Shiv";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 8;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 3;
                    break;
                case 2:
                    Weapon = LevelTwoGoblinWeapons.GreenOrb;
                    Name = "Green Orb";
                    StrenthRequirement = 1;
                    ManaRequirement = 8;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 3;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelTwoGoblinWeapons.BattleAxe;
                    Name = "Battle Axe";
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
