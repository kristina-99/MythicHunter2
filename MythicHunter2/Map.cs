using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter2
{
    internal class Map
    {
        private char[,] gameMap;
        private static readonly Random rng = new Random();

        public char[,] GameMap
        {
            get
            { 
                return gameMap;
            }
            private set
            {
                if (value.GetLength(0) > 0 && value.GetLength(1) > 0)
                {
                    gameMap = value;
                }
                else
                {
                    Console.WriteLine("Map size can't be negative. A default size is set.");
                    gameMap = new char[4, 6]; 
                }
            }
        }


        public Map() : this(4,6)
        { 
        
        }

        public Map(int sizeY, int sizeX)
        { 
            this.GameMap = new char[sizeY, sizeX];
            InitializeMap();
            GenerateMapContents();
        }

        public void PrintMap()
        {
            for (int i = 0; i < gameMap.GetLength(0); i++)
            {
                for (int j = 0; j < gameMap.GetLength(1); j++)
                {
                    Console.Write(gameMap[i, j]);
                }
                Console.WriteLine();
            }
        }

        private void InitializeMap()
        {
            for (int i = 0; i < this.GameMap.GetLength(0); i++)
            {
                for (int j = 0; j < this.GameMap.GetLength(1); j++)
                {
                    this.GameMap[i, j] = '.';
                }
            }
        }

        private void GenerateMapContents()
        {
            //initial position of the Hero
            this.GameMap[0, 0] = 'H';

            //randomly placed walls
            for (int i = 0; i <= 2; i++)
            {
                FillRandomTile('#');
            }

            //putting a monster on the map
            FillRandomTile('M');

            //two randomly placed items
            for (int i = 0; i <= 1; i++)
            {
                FillRandomTile('I');
            }
        }

        private void FillRandomTile(char tile)
        { 
            int tempY = rng.Next(0, gameMap.GetLength(0));
            int tempX = rng.Next(0, gameMap.GetLength(1));

            while (gameMap[tempY, tempX] != '.')
            {
                tempY = rng.Next(0, gameMap.GetLength(0));
                tempX = rng.Next(0, gameMap.GetLength(1));
            }

            gameMap[tempY, tempX] = tile;
        }
    }
}
