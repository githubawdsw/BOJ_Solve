using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace BFS_DFS_Reculsive
{
    
    class Making_Star11_2448
    {
        static char[,] board = new char[3500, 6500];
        static int N;
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N; j++)
                {
                    board[i, j] = ' ';
                }
            }

            Reculsive(N, 0, N - 1);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < 2 * N; j++)
                {
                    sb.Append(board[i, j]);
                }
                sb.AppendLine();
            }
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.WriteLine(sb);
            sw.Close();
        }

        public static void Reculsive( int n, int x, int y)
        {
            if (n == 3)
            {
                fill_star( x, y);
                return;
            }

            Reculsive(n / 2, x, y);
            Reculsive(n / 2, x + n / 2, y - n / 2);
            Reculsive(n / 2, x + n / 2, y + n / 2);

        }
        
        public static void fill_star( int x, int y)
        {
            board[x, y] = '*';

            board[x + 1, y - 1] = '*';
            board[x + 1, y + 1] = '*';

            board[x + 2, y - 2] = '*';
            board[x + 2, y - 1] = '*';
            board[x + 2, y] = '*';
            board[x + 2, y + 1] = '*';
            board[x + 2, y + 2] = '*';
        }

    }
}
