﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootThings
{
    public class SpiderWeapon : Weapons
    {
        public LevelOneSpiderWeapons Weapon { get; set; }

        public SpiderWeapon(int weapon)
        {
            switch (weapon)
            {
                case 1:
                    Weapon = LevelOneSpiderWeapons.PincerKnife;
                    Name = "PincerKnife";
                    StrenthRequirement = 1;
                    ManaRequirement = 1;
                    LuckRequirement = 5;
                    break;
                case 2:
                    Weapon = LevelOneSpiderWeapons.OrbofManyEyes;
                    Name = "OrbofManyEyes";
                    StrenthRequirement = 1;
                    ManaRequirement = 5;
                    LuckRequirement = 1;
                    break;
                case 3:
                    Weapon = LevelOneSpiderWeapons.WebbedHammer;
                    Name = "WebbedHammer";
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
