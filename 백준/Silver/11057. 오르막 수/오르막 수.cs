using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_11057
    {
        static int N;
        static long[,] d = new long[1005, 11];
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                d[i, 0] = 1;
                for (int j = 1; j < 10; j++)
                    d[i, j] = (d[i, j - 1] + d[i - 1, j]) % 10007;

            }
            long ans = 0;
            for (int i = 0; i < 10; i++)
            {
                ans += d[N, i] ;
            }
            Console.WriteLine(ans % 10007);
        }
    }
    
}
