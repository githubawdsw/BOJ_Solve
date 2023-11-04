using System;

namespace Dynamic
{
    
    class BOJ_17070
    {
        static void Main(string[] args)
        {   
            int n = int.Parse(Console.ReadLine());
            int[,] board = new int[20, 20];
            int[,,] dp = new int[20,20,3];
            dp[1, 2, 0] = 1;
            for (int i = 1; i <= n; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 1; j <= n; j++)
                    board[i,j] = int.Parse(inputarr[j - 1]);
            }
            for (int i = 1; i <= n; i++)
                for (int j = 3; j <= n; j++)
                    if (board[i,j] == 0)
                    {
                        dp[i, j, 0] = dp[i, j - 1, 0] + dp[i, j - 1, 2];
                        dp[i, j, 1] = dp[i - 1, j, 1] + dp[i - 1, j, 2];
                        if (board[i, j - 1] == 0 && board[i - 1, j] == 0)
                            dp[i, j, 2] = dp[i - 1, j - 1, 0] + dp[i - 1, j - 1, 1] + dp[i - 1, j - 1, 2];
                    }


            Console.WriteLine(dp[n, n, 0] + dp[n, n, 1] + dp[n, n, 2]);
        }
    }
    
}