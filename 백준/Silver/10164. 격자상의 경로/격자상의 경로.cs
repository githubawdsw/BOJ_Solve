using System;

namespace Dynamic
{
    
    class BOJ_10164
    {
        static void Main(string[] args)
        {
            string[] inputnmk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnmk[0]);
            int m = int.Parse(inputnmk[1]);
            int k = int.Parse(inputnmk[2]);

            long[,] dp = new long[20, 20];
            dp[1, 0] = 1;
            int x = k / m + 1;
            int y = k % m;
            if (y == 0)
            {
                x--;
                y = m;
            }

            if (k == 0)
            {
                x= 1;
                y = 1;
            }

            for (int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];

            for (int i = x; i <= n; i++)
                for (int j = y; j <= m; j++)
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];


            Console.WriteLine($"{dp[n,m]} ");
        }
    }
    
}
