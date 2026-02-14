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


        }

        static char[,] GenerateMap(int n, int m)
        {
            char[,] map = new char[n, m];

            Random rng = new Random();

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = '.';
                }
            }

            for (int i = 0; i <= 2; i++)
            {
                int y = rng.Next(0, n - 1);
                int x = rng.Next(0, m - 1);
                if (map[y, x] == '.')
                {
                    map[y, x] = '#';
                }
                else
                {
                    while (map[y, x] != '.')
                    {
                        y = rng.Next(0, n - 1);
                        x = rng.Next(0, m - 1);
                    }
                    map[y, x] = '#';
                }
            }

            return map;
        }
    }
}
