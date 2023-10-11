using System;

namespace Dynamic
{
    
    class BOJ_1495
    {
        static void Main(string[] args)
        {
            string[] inputnsm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnsm[0]);
            int s = int.Parse(inputnsm[1]);
            int m = int.Parse(inputnsm[2]);
            string[] inputv = Console.ReadLine().Split(' ');

            bool[,] dp = new bool[55,1005];
            dp[0, s] = true ; 
            for (int i = 1; i <= n; i++)
                for (int j = 0; j <= m; j++)
                    if (dp[i-1,j] == true)
                    {
                        if (j + int.Parse(inputv[i-1]) >= 0 && j + int.Parse(inputv[i-1]) <= m)
                            dp[i, j + int.Parse(inputv[i - 1])] = true;
                        if (j - int.Parse(inputv[i - 1]) >= 0 && j - int.Parse(inputv[i - 1]) <= m)
                            dp[i, j - int.Parse(inputv[i - 1])] = true;
                    }
            int ans = -1;
            for (int i = 0; i <= m; i++)
            {
                if (dp[n, i])
                    ans = Math.Max(ans, i);
            }
            Console.WriteLine(  ans);

        }
    }
    
}
    