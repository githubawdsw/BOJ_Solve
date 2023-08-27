using System;

namespace Dynamic
{
    
    class BOJ_2748
    {
        static int N;
        static long[] D = new long[100];
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            D[1] = 1;
            D[2] = 1;

            for (int i = 3; i <= N; i++)
                D[i] = D[i - 1] + D[i - 2];
            
            
            Console.WriteLine(D[N]) ;

        }
    }
    
}
