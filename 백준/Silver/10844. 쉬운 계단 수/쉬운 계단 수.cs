using System;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_10844
    {
        static int N;
        static long[,] D = new long[102,10];
        static void Main(string[] args)
        {
            long mod = 1000000000;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
                D[1, i] = 1;
            
            for (int i = 2; i <= N; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j != 0)
                        D[i, j] += D[i - 1, j - 1];
                    if (j != 9)
                        D[i, j] += D[i - 1, j + 1];
                    D[i, j] %= mod;
                }
            }

            long length = 0;
            for (int i = 0; i < 10; i++)
            {
                length += D[N, i];
            }
            length %= mod;
            Console.WriteLine(length) ;

        }
    }
    
}
