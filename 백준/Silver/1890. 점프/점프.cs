using System;
using System.Collections.Generic;

namespace Dynamic
{
    
    class BOJ_1890
    {
        static int[,] board = new int[105, 105];
        static int[] dx = { 1, 0 };
        static int[] dy = { 0, 1 };
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    board[i,j] = int.Parse(inputarr[j]);
            }
            long[,] dp = new long[105, 105];
            dp[0, 0] = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n - 1 && j == n - 1)
                        break;
                    dp[i + board[i, j], j] += dp[i, j];
                    dp[i, board[i, j] + j] += dp[i, j];
                }
            }
            Console.WriteLine(dp[n-1,n-1]);
        }
    }
    
}
