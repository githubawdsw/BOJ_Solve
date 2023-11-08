using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_1915
    {
        static int[,] board = new int[1005, 1005];
        static int[,] d = new int[1005, 1005];
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            for (int i = 1; i <= n; i++)
            {
                string inputarr = Console.ReadLine();
                for (int j = 1; j <= m; j++)
                    board[i, j] = int.Parse(inputarr[j-1].ToString());
            }
            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                    if (board[i,j] == 1)
                    {
                        d[i, j] = Math.Min(d[i - 1, j], d[i, j - 1]) + 1;
                        d[i, j] = Math.Min(d[i, j], d[i - 1, j - 1] + 1);
                        ans = Math.Max(ans, d[i, j]);
                    }
            }
            Console.WriteLine(ans * ans);
        }
    }
    
}
