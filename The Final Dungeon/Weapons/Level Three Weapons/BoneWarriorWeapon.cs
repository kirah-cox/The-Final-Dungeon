using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class BoneWarriorWeapon : Weapons
    {
        public LevelThreeBoneWarriorWeapons Weapon { get; set; }

        public BoneWarriorWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelThreeBoneWarriorWeapons.SteelyKnife;
                    Name = "Steely Knife";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 12;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 4.5;
                    break;
                case 2:
                    Weapon = LevelThreeBoneWarriorWeapons.OrbofMight;
                    Name = "Orb of Might";
                    StrenthRequirement = 1;
                    ManaRequirement = 12;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 4.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelThreeBoneWarriorWeapons.LongBattleSword;
                    Name = "Long Battle Sword";
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
