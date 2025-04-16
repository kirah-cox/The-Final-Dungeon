using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class FrogWeapon : Weapons
    {
        public LevelOneFrogWeapons Weapon { get; set; }

        public FrogWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelOneFrogWeapons.FlySnatcherDagger;
                    Name = "Fly Snatcher Dagger";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 5;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1;
                    LuckMultiplier = 1.5;
                    break;
                case 2:
                    Weapon = LevelOneFrogWeapons.OrbofBleps;
                    Name = "Orb of Bleps";
                    StrenthRequirement = 1;
                    ManaRequirement = 5;
                    LuckRequirement = 1;
                    StrengthMultiplier = 1;
                    ManaMultiplier = 1.5;
                    LuckMultiplier = 1;
                    break;
                case 3:
                    Weapon = LevelOneFrogWeapons.LilyAxe;
                    Name = "Lily Axe";
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
