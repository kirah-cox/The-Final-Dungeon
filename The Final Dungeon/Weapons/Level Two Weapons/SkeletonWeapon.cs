using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class SkeletonWeapon : Weapons
    {
        public LevelTwoSkeletonWeapons Weapon { get; set; }

        public SkeletonWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelTwoSkeletonWeapons.RibBoneKnife;
                    Name = "Rib Bone Knife";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 10;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 2.7;
                    break;
                case 2:
                    Weapon = LevelTwoSkeletonWeapons.OrbofBones;
                    Name = "Orb of Bones";
                    StrenthRequirement = 1;
                    ManaRequirement = 10;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 2.7;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelTwoSkeletonWeapons.FemurLongSword;
                    Name = "Femur Long Sword";
                    StrenthRequirement = 10;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    StrengthMultiplier = 2.7;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
