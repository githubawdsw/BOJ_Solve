using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon2
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        { 
            int T = int.Parse(Console.ReadLine());
            for (int l = 0; l < T; l++)
            {
                int[,] board;
                string[] inputValue = Console.ReadLine().Split(" ");
                int n = int.Parse(inputValue[0]);
                int d = int.Parse(inputValue[1]);
                board = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    string[] inputArr = Console.ReadLine().Split(" ");
                    for (int j = 0; j < n; j++)
                        board[i, j] = int.Parse(inputArr[j]);
                }
                ArrCircle(board, n , d);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        sb.Append(board[i, j]);
                        sb.Append(" ");
                    }
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb.ToString());

        }

        static void ArrCircle(int[,] board,  int n, int d)
        {
            int[,] ans = new int[n, n];
            if (d < 0)
                d = 360 + d;
            d = d / 45;

            for (int l = 0; l < d; l++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == i)
                            ans[i, n / 2] = board[i, j];
                        else if (j == n  / 2)
                            ans[i, n - 1 - i] = board[i, n / 2];
                        else if (j == n - i -1)
                            ans[n / 2, n - 1 - i] = board[ i, n - 1 - i];
                        else if (i == n  / 2)
                            ans[j, j] = board[n / 2, j];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if(ans[i,j] != 0)
                            board[i, j] = ans[i, j];
                    }
                }
            }


        }
        
    }
}