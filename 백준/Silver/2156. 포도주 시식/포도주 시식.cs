using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_2156
    {
        static int N;
        static int[] D = new int[ 10005];
        static List<int> inputlist = new List<int>();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            inputlist.Add(0);
            for (int i = 0; i < N; i++)
                inputlist.Add(int.Parse(Console.ReadLine()));
            inputlist.Add(0);

            D[1] = inputlist[1];
            D[2] = inputlist[1] + inputlist[2];
            for (int i = 3; i <= N; i++)
            {
                D[i] = Math.Max(D[i - 1], D[i - 2] + inputlist[i]);
                D[i] = Math.Max(D[i], D[i - 3] + inputlist[i - 1] + inputlist[i]);
            }

            Console.WriteLine(D[N]);
        }
    }
    
}
