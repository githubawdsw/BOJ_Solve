using System;
namespace GreedyAlgorithm
{
    
    class BOJ_1026
    {
        static int n;
        static int[] A = new int[55];
        static int[] B = new int[55];
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            string[] inputA = Console.ReadLine().Split(' ');
            string[] inputB = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(inputA[i]);
                B[i] = int.Parse(inputB[i]);
            }
            Array.Sort(A, 0, n);
            Array.Sort(B, 0, n);

            int S = 0;
            for (int i = 0; i < n; i++)
                S += A[i] * B[n - i - 1];
            Console.WriteLine(S);
        }
    }
    
}
