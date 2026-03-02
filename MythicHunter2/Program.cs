using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MythicHunter2;
using MythicHunter2.Items;

namespace MythicHunter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            Map map = new Map();
            Hero hero = new Hero();
            Random rng = new Random();

            while (!gameOver)
            {

                //1.Print map

                map.PrintMap();

                //2.Save current Hero coordinates

                int tempHeroCoordinatesY = hero.CurrentYPosition;
                int tempHeroCoordinatesX = hero.CurrentXPosition;

                //3.Accept console input

                Console.WriteLine("Please enter the next direction (w, a, s or d):");
                string userInput = Console.ReadLine();

                hero.Move(Char.ToLower(userInput[0]));

                char tempHeroTile = map.GameMap[tempHeroCoordinatesY, tempHeroCoordinatesX];
                char currentHeroTile = map.GameMap[hero.CurrentYPosition, hero.CurrentXPosition];

                //4.Check for a wall and revert to the previous position if needed
                if (currentHeroTile == '#')
                {
                    hero.CurrentXPosition = tempHeroCoordinatesX;
                    hero.CurrentYPosition = tempHeroCoordinatesY;
                }
                else if (currentHeroTile == '.')
                {
                    tempHeroTile = '.';
                    currentHeroTile = 'H';
                }
                else if (currentHeroTile == 'I')
                {
                    tempHeroTile = '.';
                    currentHeroTile = 'H';
                    int itemChoice = rng.Next(1, 5);


                    Item item;
                    switch (itemChoice)
                    {
                        case 1: item = new Armor(); break;
                        case 2: item = new Weapon(); break;
                        case 3: item = new Magic(); break;
                        case 4: item = new Potion(); break;
                        default: throw new Exception("Invalid item choice");
                    }

                    hero.Inventory.Add(item);
                }
                else if (currentHeroTile == 'M')
                {
                    tempHeroTile = '.';
                    currentHeroTile = 'H';
                    Monster monster = new Monster();

                    bool heroWins = Combat(hero, monster);
                }
                map.GameMap[tempHeroCoordinatesY, tempHeroCoordinatesX] = tempHeroTile;
                map.GameMap[hero.CurrentYPosition, hero.CurrentXPosition] = currentHeroTile;
            }


        }
        public static bool Combat(Hero hero, Monster monster)
        {
            if (hero.Inventory.Count > 0)
            {
                string userInput = Console.ReadLine();

                Console.WriteLine("Which item do you want to use for the combat?");
                for (int i = 0; i < hero.Inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {hero.Inventory[i].Name}");
                }
                Console.WriteLine($"{hero.Inventory.Count + 1}. I don't want to use an item");

                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int choice))
                {
                    if (choice >= 1 && choice <= hero.Inventory.Count)
                    {
                        hero.Inventory[choice - 1].ActivateSpecialEffect(hero);
                    }
                    else if (choice == hero.Inventory.Count + 1)
                    {
                        Console.WriteLine("You chose not to use an item.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Health -= hero.Power;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The hero has attacked the monster. The monster has {monster.Health} healthpoints left.");
                Console.Clear();
                if (monster.Health <= 0)
                {
                    return true;
                }

                hero.Health -= monster.Power;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The monster attacked the hero. Hero HP: {hero.Health}");
                Console.ResetColor();

                if (hero.Health <= 0)
                {
                    return false;
                }
            }

            return true;
        }


    }
}


    

    

