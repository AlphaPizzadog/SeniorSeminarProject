using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace ArrayProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreateGrid();

            Console.ReadKey();
        }
        public static void CreateGrid()
        {
            int width = 20;
            int height = 20;

            int[,] grid = new int[width, height];
            grid[2, 3] = 3;


            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    grid[x, y] = x + y;
                    Console.Write(grid[x,y] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
