using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class easy2048_12100
    {
        static int n;
        static int[,] board1 = new int[22, 22];
        static int[,] board2 = new int[22, 22];
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] inputValue = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    board1[i, j] = int.Parse(inputValue[j]);
            }

            int max = 0;
            for (int temp = 0; temp < 1024; temp++)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        board2[i, j] = board1[i, j];

                int brute = temp;
                for (int i = 0; i < 5; i++)
                {
                    int dir = brute % 4;
                    brute /= 4;
                    slope(dir);
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        max = Math.Max(max, board2[i, j]);
                    }
                }
            }
            Console.WriteLine(max);

        }

        static void slope(int dir)
        {
            for (int i = 0; i < dir; i++)
            {
                rotate();
            }
            for (int i = 0; i < n; i++)
            {
                int[] tilted = new int[21];
                int idx = 0;
                for (int j = 0; j < n; j++)
                {
                    if (board2[i, j] == 0)
                        continue;
                    if (tilted[idx] == 0)
                        tilted[idx] = board2[i, j];
                    else if (tilted[idx] == board2[i, j])
                        tilted[idx++] *= 2;
                    else
                        tilted[++idx] = board2[i, j];
                }
                for (int j = 0; j < n; j++)
                {
                    board2[i, j] = tilted[j];
                }
            }
        }

        static void rotate()
        {
            int[,] temp = new int[22, 22];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    temp[i, j] = board2[i, j];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    board2[i, j] = temp[n - 1 - j, i];
        }
    }
}
