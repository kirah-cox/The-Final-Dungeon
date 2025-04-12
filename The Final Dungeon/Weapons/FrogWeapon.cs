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
                    Name = "FlySnatcherDagger";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 5;
                    break;
                case 2:
                    Weapon = LevelOneFrogWeapons.OrbofBleps;
                    Name = "OrbofBleps";
                    StrenthRequirement = 1;
                    ManaRequirement = 5;
                    LuckRequirement = 1;
                    break;
                case 3:
                    Weapon = LevelOneFrogWeapons.LilyAxe;
                    Name = "LilyAxe";
                    StrenthRequirement = 5;
                    ManaRequirement = 1;
                    LuckRequirement = 1;
                    break;
                default:
                    break;
            }
        }
    }
}
