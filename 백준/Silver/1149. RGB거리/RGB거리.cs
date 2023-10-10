using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    
    class BOJ_1149
    {
        static int N;
        static int[,] D = new int[1001, 3];
        // 0 : R , 1 : G , B : 2
        static int[] R = new int[1001];
        static int[] G = new int[1001];
        static int[] B = new int[1001];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                string[] inputCost = Console.ReadLine().Split(' ');
                R[i] = int.Parse(inputCost[0]);
                G[i] = int.Parse(inputCost[1]);
                B[i] = int.Parse(inputCost[2]);
            }
            D[1, 0] = R[1];
            D[1, 1] = G[1];
            D[1, 2] = B[1];
            for (int i = 1; i <= N; i++)
            {
                D[i, 0] = Math.Min(D[i - 1, 1], D[i - 1, 2]) + R[i];
                D[i, 1] = Math.Min(D[i - 1, 0], D[i - 1, 2]) + G[i];
                D[i, 2] = Math.Min(D[i - 1, 0], D[i - 1, 1]) + B[i];
            }
            int ans = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                ans = Math.Min(D[N, i], ans);
            }
            Console.WriteLine(ans);
        }
    }
    
}
