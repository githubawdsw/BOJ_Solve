using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_2302
    {
        static int N, m;
        static int[] D = new int[ 45];
        static List<int> inputlist = new List<int>();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            inputlist.Add(0);
            for (int i = 0; i < m; i++)
                inputlist.Add(int.Parse(Console.ReadLine()));

            D[1] = 1;
            D[0] = 1;

            for (int i = 2; i <= N; i++)
            {
                D[i] = D[i - 1] + D[i - 2];
            }
            inputlist.Add(N+1);
            int ans = 1;
            for (int i = 1; i < inputlist.Count; i++)
            {
                ans *= D[inputlist[i] - inputlist[i-1] - 1];
            }
            Console.WriteLine(ans);
        }
    }
    
}
