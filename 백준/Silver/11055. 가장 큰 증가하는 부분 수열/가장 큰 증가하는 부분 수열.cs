using System;

namespace Dynamic
{
    
    class BOJ_11055
    {
        static int N;
        static int[] D = new int[ 1005];
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            string[] inputArr = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
                D[i] = int.Parse(inputArr[i]);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < i; j++)
                {
                    if (int.Parse(inputArr[j]) < int.Parse(inputArr[i]))
                        D[i] = Math.Max( D[j] + int.Parse(inputArr[i]) , D[i] );
                }

            int max = int.MinValue;
            for (int i = 0; i < N; i++)
                max = Math.Max(D[i], max);

            Console.WriteLine(max); 

        }
    }
        
}
