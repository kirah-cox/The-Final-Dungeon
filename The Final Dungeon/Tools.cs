using AllCreations;
using AllMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LootThings;

namespace MyTools;

class Tools
{
    public static int UpDown { get; set; } = 1;
    public static int LeftRight { get; set; } = 1;
    public static bool Up { get; set; } = false;
    public static bool Down { get; set; } = false;
    public static bool Left { get; set; } = false;
    public static bool Right { get; set; } = false;
    public static bool EncounteredEnemy { get; set; } = false;
    public static bool ChestEmpty { get; set; } = false;
    public static bool ObtainedKey { get; set; } = false;
    public static bool CrossedGap { get; set; } = false;
    public static bool ObtainedFeather { get; set; } = false;
    public static int MapNumber { get; set; } = 0;

    
    public static PlayerClass MenuScreen()
    {
        while (true)
        {
            Console.WriteLine("Welcome to The Final Dungeon. Press WASD to move, E to interact, R to access inventory, and Z to access stats.");
            Console.WriteLine("What class do you select?");
            Console.WriteLine("1: Warrior");
            Console.WriteLine("     Strength:   5");
            Console.WriteLine("     Mana:       1");
            Console.WriteLine("     Luck:       1");
            Console.WriteLine("2: Wizard");
            Console.WriteLine("     Strength:   1");
            Console.WriteLine("     Mana:       5");
            Console.WriteLine("     Luck:       1");
            Console.WriteLine("3: Rogue");
            Console.WriteLine("     Strength:   1");
            Console.WriteLine("     Mana:       1");
            Console.WriteLine("     Luck:       5");

            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.D1)
            {
                return PlayerClass.Warrior;
            }
            else if (key == ConsoleKey.D2)
            {
                return PlayerClass.Wizard;
            }
            else if (key == ConsoleKey.D3)
            {
                return PlayerClass.Rogue;
            }

            Console.Clear();
        }
    }

    public static void Move(Player player, char[][] charMap, StringBuilder sb, string character)
    {
        Up = false;
        Down = false;
        Left = false;
        Right = false;

        var key = Console.ReadKey().Key;
        if (key == ConsoleKey.W
            && charMap[UpDown - 1][LeftRight] != '~'
            && charMap[UpDown - 1][LeftRight] != 'O'
            && charMap[UpDown - 1][LeftRight] != '0')
        {
            if(charMap[UpDown - 1][LeftRight] == '.')
            {
                UpDown--;
                Up = true;
                Console.Clear();
            }
            else if((charMap[UpDown - 2][LeftRight] == '.') && (charMap[UpDown - 1][LeftRight] == ' ') && ObtainedFeather)
            {
                UpDown -= 2;
                Up = true;
                CrossedGap = true;
                Console.Clear();
            }
        }
        else if (key == ConsoleKey.S
            && charMap[UpDown + 1][LeftRight] != '~'
            && charMap[UpDown + 1][LeftRight] != 'O'
            && charMap[UpDown + 1][LeftRight] != '0')
        {
            if (charMap[UpDown + 1][LeftRight] == '.')
            {
                UpDown++;
                Down = true;
                Console.Clear();
            }
            else if ((charMap[UpDown + 2][LeftRight] == '.') && (charMap[UpDown + 1][LeftRight] == ' ') && ObtainedFeather)
            {
                UpDown += 2;
                Down = true;
                CrossedGap = true;
                Console.Clear();
            }
        }
        else if (key == ConsoleKey.A
            && charMap[UpDown][LeftRight - 1] != ':'
            && charMap[UpDown][LeftRight - 1] != 'O'
            && charMap[UpDown][LeftRight - 1] != '0')
        {
            if (charMap[UpDown][LeftRight - 1] == '.')
            {
                LeftRight--;
                Left = true;
                Console.Clear();
            }
            else if ((charMap[UpDown][LeftRight - 2] == '.') && (charMap[UpDown][LeftRight - 1] == ' ') && ObtainedFeather)
            {
                LeftRight -= 2;
                Left = true;
                CrossedGap = true;
                Console.Clear();
            }
        }
        else if (key == ConsoleKey.D
            && charMap[UpDown][LeftRight + 1] != ':'
            && charMap[UpDown][LeftRight + 1] != 'O'
            && charMap[UpDown][LeftRight + 1] != '0')
        {
            if (charMap[UpDown][LeftRight + 1] == '.')
            {
                LeftRight++;
                Right = true;
                Console.Clear();
            }
            else if (charMap[UpDown][LeftRight + 2] == '.' && (charMap[UpDown][LeftRight + 1] == ' ') && ObtainedFeather)
            {
                LeftRight += 2;
                Right = true;
                CrossedGap = true;
                Console.Clear();
            }
        }
        else if (key == ConsoleKey.R)
        {
            Player.DisplayInventory(player);
        }
        else if (key == ConsoleKey.E && !Map.LevelOneChests[Tools.MapNumber]
            && (charMap[UpDown - 1][LeftRight] == 'm'
            || charMap[UpDown + 1][LeftRight] == 'm'
            || charMap[UpDown][LeftRight - 1] == 'm'
            || charMap[UpDown][LeftRight + 1] == 'm'))
        {
            Chest.AddPotion(player);
            Map.LevelOneChests[Tools.MapNumber] = true;
        }
        else if(key == ConsoleKey.E && Map.LevelOneChests[Tools.MapNumber]
            && (charMap[UpDown - 1][LeftRight] == 'm'
            || charMap[UpDown + 1][LeftRight] == 'm'
            || charMap[UpDown][LeftRight - 1] == 'm'
            || charMap[UpDown][LeftRight + 1] == 'm'))
        {
            Console.Clear();
            Console.WriteLine("The chest is empty.");
            PressEnter();
        }
        else if (key == ConsoleKey.E
            && (charMap[UpDown - 1][LeftRight] == '0'
            || charMap[UpDown + 1][LeftRight] == '0'
            || charMap[UpDown][LeftRight - 1] == '0'
            || charMap[UpDown][LeftRight + 1] == '0'))
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, '.');
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            MapNumber++;
            UpDown = Map.LevelOneUpDown[2 * MapNumber];
            LeftRight = Map.LevelOneLeftRight[2 * MapNumber];
        }
        else if (key == ConsoleKey.E
            && (charMap[UpDown - 1][LeftRight] == 'O'
            || charMap[UpDown + 1][LeftRight] == 'O'
            || charMap[UpDown][LeftRight - 1] == 'O'
            || charMap[UpDown][LeftRight + 1] == 'O'))
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, '.');
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            MapNumber--;
            if (MapNumber == 0)
            {
                UpDown = Map.LevelOneUpDown[1];
                LeftRight = Map.LevelOneLeftRight[1];
            }
            else
            {
                UpDown = Map.LevelOneUpDown[2 * MapNumber + 1];
                LeftRight = Map.LevelOneLeftRight[2 * MapNumber + 1];
            }
        }
        else if (key == ConsoleKey.E && !ObtainedKey
            && (charMap[UpDown - 1][LeftRight] == 'K'
            || charMap[UpDown + 1][LeftRight] == 'K'
            || charMap[UpDown][LeftRight - 1] == 'K'
            || charMap[UpDown][LeftRight + 1] == 'K'))
        {
            Console.Clear();
            Console.WriteLine("You have obtained a key.");
            PressEnter();
            sb.Append(charMap[UpDown]).Replace('K', '.');
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[UpDown + 1]).Replace('K', '.');
            charMap[UpDown + 1] = sb.ToString().ToCharArray();
            sb.Clear();
            sb.Append(charMap[UpDown - 1]).Replace('K', '.');
            charMap[UpDown - 1] = sb.ToString().ToCharArray();
            sb.Clear();
            ObtainedKey = true;
        }
        else if (key == ConsoleKey.E && !ObtainedFeather
            && (charMap[UpDown - 1][LeftRight] == 'M'
            || charMap[UpDown + 1][LeftRight] == 'M'
            || charMap[UpDown][LeftRight - 1] == 'M'
            || charMap[UpDown][LeftRight + 1] == 'M'))
        {
            Console.Clear();
            Console.WriteLine("You have obtained the magical feather! You can now jump over small gaps.");
            PressEnter();
            ObtainedFeather = true;
        }
        else if (key == ConsoleKey.E && ObtainedFeather
            && (charMap[UpDown - 1][LeftRight] == 'M'
            || charMap[UpDown + 1][LeftRight] == 'M'
            || charMap[UpDown][LeftRight - 1] == 'M'
            || charMap[UpDown][LeftRight + 1] == 'M'))
        {
            Console.Clear();
            Console.WriteLine("The chest is empty.");
            PressEnter();
        }

        Random random = new Random();
        int potentialEnemy = random.Next(1, 101);

        if (potentialEnemy <= 1)
        {
            EncounteredEnemy = true;
        }
    }

    public static void DrawMainMap(StringBuilder sb, char[][] charMap, string character)
    {
        Console.SetCursorPosition(0, 0);
        Console.CursorVisible = false;

        CharacterMovesUpOrDown(sb, charMap, character);

        if (Up)
        {
            CharacterMovesUpOrDown(sb, charMap, character);
            ClearAfterMovingUp(sb, charMap, character);
        }
        else if (Down)
        {
            CharacterMovesUpOrDown(sb, charMap, character);
            ClearAfterMovingDown(sb, charMap, character);
        }
        else if (Left)
        {
            MoveAndClearLeft(sb, charMap, character);
        }
        else if (Right)
        {
            MoveAndClearRight(sb, charMap, character);
        }

        foreach (var item in charMap)
        {
            Console.WriteLine(item);
        }
    }

    public static void CharacterMovesUpOrDown(StringBuilder sb, char[][] charMap, string character)
    {
        sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character);
        charMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void ClearAfterMovingUp(StringBuilder sb, char[][] charMap, string character)
    {
        if (CrossedGap)
        {
            sb.Append(charMap[UpDown + 2]).Remove(LeftRight, 1).Insert(LeftRight, ".");
            charMap[UpDown + 2] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
            return;
        }

        sb.Append(charMap[UpDown + 1]).Remove(LeftRight, 1).Insert(LeftRight, ".");
        charMap[UpDown + 1] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void ClearAfterMovingDown(StringBuilder sb, char[][] charMap, string character)
    {
        if (CrossedGap)
        {
            sb.Append(charMap[UpDown - 2]).Remove(LeftRight, 1).Insert(LeftRight, ".");
            charMap[UpDown - 2] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
            return;
        }

        sb.Append(charMap[UpDown - 1]).Remove(LeftRight, 1).Insert(LeftRight, ".");
        charMap[UpDown - 1] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void MoveAndClearLeft(StringBuilder sb, char[][] charMap, string character)
    {
        if (CrossedGap)
        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight + 1, 2).Insert(LeftRight + 1, " .");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
            return;
        }

        sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight + 1, 1).Insert(LeftRight + 1, ".");
        charMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void MoveAndClearRight(StringBuilder sb, char[][] charMap, string character)
    {
        if (CrossedGap)

        {
            sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight - 2, 1).Insert(LeftRight - 2, ".");
            charMap[UpDown] = sb.ToString().ToCharArray();
            sb.Clear();
            CrossedGap = false;
            return;
        }

        sb.Append(charMap[UpDown]).Remove(LeftRight, 1).Insert(LeftRight, character).Remove(LeftRight - 1, 1).Insert(LeftRight - 1, ".");
        charMap[UpDown] = sb.ToString().ToCharArray();
        sb.Clear();
    }

    public static void Battle(Player player, Enemy enemy)
    {
        Console.WriteLine($"You have encountered {enemy.Class}.");
        PressEnter();

        while (enemy.Health > 0 && player.Health > 0)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Your health: {player.Health}");
                Console.WriteLine($"Enemy health: {enemy.Health}");
                Console.WriteLine("1: Attack");
                Console.WriteLine("2: Use Item");

                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.D1)
                {
                    int playerAttack = player.Attack();
                    Console.WriteLine($"You attacked {enemy.Class} with a damage of {playerAttack}.");
                    enemy.TakeDamage(playerAttack);
                    Thread.Sleep(2000);
                    break;
                }
                else if (key == ConsoleKey.D2)
                {
                    bool haveItems = false;
                    int lineNumber = 1;
                    if (player.PotionInventory.Count() >= 1)
                    {
                        haveItems = true;
                        while (true)
                        {
                            List<Potions.PotionType> potionTypes = new List<Potions.PotionType>();

                            Console.WriteLine("Which item would you like to use?");

                            var orderedPotions = player.PotionInventory.OrderBy(potion => potion.Key).Where(potion => potion.Value != 0);
                            foreach (var line in orderedPotions)
                            {
                                Console.WriteLine($"{lineNumber}. {line.Key} Potion: {line.Value}");
                                potionTypes.Add(line.Key);
                                lineNumber++;
                            }

                            bool correctPotion = false;
                            while (!correctPotion)
                            {
                                var newKey = Console.ReadKey().Key;
                                
                                if (newKey == ConsoleKey.D1)
                                {
                                    correctPotion = Potions.UsePotion(player, potionTypes[0]) ? true : false;
                                }
                                else if (newKey == ConsoleKey.D2 && lineNumber >= 2)
                                {
                                    correctPotion = Potions.UsePotion(player, potionTypes[1]) ? true : false;
                                }
                                else if (newKey == ConsoleKey.D3 && lineNumber >= 3)
                                {
                                    correctPotion = Potions.UsePotion(player, potionTypes[2]) ? true : false;
                                }
                                else if (newKey == ConsoleKey.D4 && lineNumber >= 4)
                                {
                                    correctPotion = Potions.UsePotion(player, potionTypes[3]) ? true : false;
                                }
                            }

                            if (correctPotion)
                            {
                                break;
                            }

                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not have any items you can use.");
                        Thread.Sleep(2000);
                        PressEnter();
                    }

                    if (!Potions.AlreadyUsedPotion && haveItems)
                    {
                        break;
                    }
                }

                Console.Clear();
            }

            if (enemy.Health > 0)
            {
                int enemyAttack = enemy.Attack();
                Console.WriteLine($"{enemy.Class} attacks you with a damage of {enemyAttack}.");
                Thread.Sleep(2000);
                player.TakeDamage(enemyAttack);
            }
        }

        if (player.Health <= 0)
        {
            Console.WriteLine("You have died.");
            Environment.Exit(0);
        }

        player.GainExperience(enemy.Experience);
        Console.WriteLine($"You have defeated {enemy.Class} and have gained {enemy.Experience} experience.");

        if (Potions.UsedLuckPotion)
        {
            player.Luck -= 10;
            Potions.UsedLuckPotion = false;
        }

        if (Potions.UsedStrengthPotion)
        {
            player.Strength -= 10;
            Potions.UsedStrengthPotion = false;
        }

        if (Potions.UsedManaPotion)
        {
            player.Mana -= 10;
            Potions.UsedManaPotion = false;
        }

        PressEnter();

        Console.Clear();
    }

    public static void PressEnter()
    {
        Console.WriteLine("Press enter to continue.");
        
        bool enterPressed = false;
        while (!enterPressed)
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                enterPressed = true;
            }
        }
    }
}
