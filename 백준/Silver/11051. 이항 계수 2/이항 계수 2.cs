using System;
namespace MathAlgorithm
{
    
    class BOJ_11051
    {
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnk[0]);
            int k = int.Parse(inputnk[1]);
            int[,] d = new int[1005, 1005];

            for (int i = 1; i <= n; i++)
            {
                d[i, 0] = 1;
                d[i, i] = 1;
                for (int j = 1; j < i; j++)
                    d[i, j] =( d[i - 1, j - 1] + d[i - 1, j] ) % 10007;
            }
            Console.WriteLine(d[n,k]);
        }
    }
    
}
