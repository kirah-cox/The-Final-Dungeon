using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MyTools;
using AllCreations;
using LootThings;
using AllMaps;

namespace SavingAndLoading
{
    public class SaveLoad
    {
        public static string filePath = "C:\\Users\\kirah\\source\\repos\\The-Final-Dungeon\\The Final Dungeon\\SavingAndLoading\\SaveFile.txt";
        public static void Save(Player player)
        {
            string jsonLevelNumber = JsonSerializer.Serialize(Tools.LevelNumber);
            string jsonMapNumber = JsonSerializer.Serialize(Tools.MapNumber);
            string jsonPlayer = JsonSerializer.Serialize(player);
            string jsonWeaponInventory = JsonSerializer.Serialize(player.WeaponInventory);
            string jsonPotionInventory = JsonSerializer.Serialize(player.PotionInventory);
            string jsonObtainedKey = JsonSerializer.Serialize(Tools.ObtainedKey);
            string jsonObtainedFeather = JsonSerializer.Serialize(Tools.ObtainedFeather);
            string jsonBossRoom = JsonSerializer.Serialize(Tools.BossRoom);
            string jsonChestList = JsonSerializer.Serialize(Tools.ChestList);
            string jsonObtainedIceSkates = JsonSerializer.Serialize(Tools.ObtainedIceSkates);


            using (StreamWriter sw = new StreamWriter(filePath))
    	    {
        	    sw.WriteLine(jsonLevelNumber);
        	    sw.WriteLine(jsonMapNumber);
        	    sw.WriteLine(jsonPlayer);
        	    sw.WriteLine(jsonWeaponInventory);
        	    sw.WriteLine(jsonPotionInventory);
        	    sw.WriteLine(jsonObtainedKey);
        	    sw.WriteLine(jsonObtainedFeather);
        	    sw.WriteLine(jsonBossRoom);
        	    sw.WriteLine(jsonChestList);
        	    sw.WriteLine(jsonObtainedIceSkates);
    	    }
        }

        public static void Load(StringBuilder sb, Character character, out Player player)
        {
            string[] loading = File.ReadAllLines(filePath);

            int loadedLevelNumber = JsonSerializer.Deserialize<int>(loading[0]);
            int loadedMapNumber = JsonSerializer.Deserialize<int>(loading[1]);
            var loadedPlayer = JsonSerializer.Deserialize<Player>(loading[2]);
            var loadedWeaponInventory = JsonSerializer.Deserialize<List<Weapons>>(loading[3]);
            var loadedPotionInventory = JsonSerializer.Deserialize<Dictionary<Potions.PotionType, int>>(loading[4]);
            bool loadedObtainedKey = JsonSerializer.Deserialize<bool>(loading[5]);
            bool loadedObtainedFeather = JsonSerializer.Deserialize<bool>(loading[6]);
            bool loadedBossRoom = JsonSerializer.Deserialize<bool>(loading[7]);
            var loadedChestList= JsonSerializer.Deserialize<List<List<bool>>>(loading[8]);
            bool loadedObtainedIceSkates = JsonSerializer.Deserialize<bool>(loading[9]);

            player = loadedPlayer;

            Tools.LevelNumber = loadedLevelNumber;
            Tools.MapNumber = loadedMapNumber;
            Tools.ObtainedKey = loadedObtainedKey;
            Tools.ObtainedFeather = loadedObtainedFeather;
            Tools.BossRoom = loadedBossRoom;
            Tools.ObtainedIceSkates = loadedObtainedIceSkates;

            if (loadedWeaponInventory != null)
            {
                foreach (var weapon in loadedWeaponInventory)
                {
                    player.WeaponInventory.Add(weapon);
                }
            }
            if (loadedPotionInventory != null)
            {
                foreach (var potion in loadedPotionInventory)
                {
                    player.PotionInventory.Add(potion.Key, potion.Value);
                }
            }
            if (loadedChestList != null)
            {
                for (int i = 0; i < 5; i++)
                {
                    FirstLevelMaps.LevelOneChests[i] = loadedChestList[0][i];
                    SecondLevelMaps.LevelTwoChests[i] = loadedChestList[1][i];
                    ThirdLevelMaps.LevelThreeChests[i] = loadedChestList[2][i];
                }
            }

            character.UpDown = Tools.UpDownList[Tools.LevelNumber][2 * Tools.MapNumber];
            character.LeftRight = Tools.LeftRightList[Tools.LevelNumber][2 * Tools.MapNumber];

            Console.Clear();
        }
    }
}
