using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{

    class BOJ_2579
    {
        static int N;
        static int[] stairScore = new int[303];
        static int[,] D = new int[303, 3];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
                stairScore[i] = int.Parse(Console.ReadLine());

            D[1, 1] = stairScore[1]; D[1, 2] = 0;
            D[2, 1] = stairScore[2]; D[2, 2] = stairScore[1] + stairScore[2];
            for (int i = 3; i <= N ; i++)
            {
                D[i, 1] = Math.Max(D[i - 2, 1], D[i - 2, 2]) + stairScore[i];
                D[i, 2] = D[i - 1, 1] + stairScore[i];
            }

            Console.WriteLine(Math.Max(D[N,1] , D[N,2]));
        }
    }
}
