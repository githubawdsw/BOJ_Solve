using System;
using System.Text;

namespace Dynamic
{
    
    class BOJ_11726
    {
        static int N;
        static int[] D = new int[1001];

        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            D[1] = 1;
            D[2] = 2;
            for (int i = 3; i <= N; i++)
            {
                D[i] = (D[i - 1] + D[i - 2]) % 10007;
            }
            Console.WriteLine(D[N]);
        }
    }
    
}
