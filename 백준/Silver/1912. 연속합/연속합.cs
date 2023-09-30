using System;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_1912
    {
        static int N;
        static int[] D = new int[ 100005];
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            string[] inputArr = Console.ReadLine().Split(' ');
            D[1] = int.Parse(inputArr[0]);
            
            for (int i = 2; i <= N; i++)
                D[i] = Math.Max( D[i - 1] + int.Parse(inputArr[i - 1]) , int.Parse(inputArr[i-1]) );

            int max = int.MinValue
                ;
            for (int i = 1; i <= N; i++)
            {
                max = Math.Max(D[i], max);
            }
            Console.WriteLine(max); 

        }
    }
        
}
