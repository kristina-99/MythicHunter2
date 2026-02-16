using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            Map map = new Map();
            Hero hero = new Hero();


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

                //4.Check for a wall and revert to the previous position if needed
                if (map.GameMap[hero.CurrentYPosition, hero.CurrentXPosition] == '#')
                {
                    hero.CurrentXPosition = tempHeroCoordinatesX;
                    hero.CurrentYPosition = tempHeroCoordinatesY;
                }
                else
                {
                    map.GameMap[tempHeroCoordinatesY, tempHeroCoordinatesX] = '.';
                    map.GameMap[hero.CurrentYPosition, hero.CurrentXPosition] = 'H';
                }

            }
        }
  
    }
}
