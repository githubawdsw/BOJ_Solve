using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_11052
    {
        static int N;
        static List<int> D = new List<int>();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            string[] inpuarr = Console.ReadLine().Split(' ');
            D.Add(0);
            for (int i = 0; i < inpuarr.Length; i++)
                D.Add(int.Parse(inpuarr[i]));
            

            for (int i = 1; i <= N; i++)
                for (int j = 1; j < i; j++)
                    D[i] = Math.Max(D[i - j] + D[j], D[i]);
                
            
            Console.WriteLine(D[N]);
        }
    }
    
}
