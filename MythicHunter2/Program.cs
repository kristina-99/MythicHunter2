using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                }
                else if (currentHeroTile == 'M')
                { 
                    Monster monster = new Monster();

                    if(hero.)
                }

                map.GameMap[tempHeroCoordinatesY, tempHeroCoordinatesX] = tempHeroTile;
                map.GameMap[hero.CurrentYPosition, hero.CurrentXPosition] = currentHeroTile;
            }

            
        }
  
    }
}
