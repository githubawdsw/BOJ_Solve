using System;
using System.Collections.Generic;
using System.Text;
namespace BFS_DFS_Reculsive
{
    
    class Making_Star10_2447
    {
        static char[,] board = new char[3000, 3000];
        static int N;
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = ' ';
                }
            }

            Reculsive( N , 0, 0);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sb.Append(board[i, j]);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }

        public static void Reculsive( int n, int x, int y)
        {
            if (n == 1)
            {
                board[x,y] = '*';
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1)
                        continue;
                    Reculsive(n / 3, x + n / 3 * i, y + n / 3 * j);
                }
            }
        }

    }
}
