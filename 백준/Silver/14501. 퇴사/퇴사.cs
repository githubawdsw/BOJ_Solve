using System;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_14501
    {
        static int N;
        static int[] p = new int[20];
        static int[] t = new int[20];
        static int[] D = new int[20];
        static void Main(string[] args)
        {

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                t[i] = int.Parse(inputarr[0]);
                p[i] = int.Parse(inputarr[1]);
            }

            for (int i = N; i >= 1; i--)
            {
                if (i + t[i] <= N + 1)
                    D[i] = Math.Max(D[i + t[i]] + p[i], D[i + 1]);
                else
                    D[i] = D[i + 1];
            }
            Console.WriteLine(D.Max());

        }
    }
    
}
