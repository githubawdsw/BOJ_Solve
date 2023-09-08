using System;
using System.Collections.Generic;

namespace MathAlgorithm
{
    
    class BOJ_2485
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> inputlist = new List<int>();
            for (int i = 0; i < n; i++)
                inputlist.Add(int.Parse(Console.ReadLine()));

            List<int> disList = new List<int>();
            for (int i = 1; i < n; i++)
                disList.Add(Math.Abs(inputlist[i - 1] - inputlist[i]));

            int dis = disList[0];
            for (int i = 1;i < disList.Count; i++)
                dis = GCD(dis, disList[i]);

            int ans = 0;
            for (int i = 1; i < n; i++)
            {
                if (Math.Abs(inputlist[i] - inputlist[i - 1]) > dis)
                    ans +=( inputlist[i] - inputlist[i - 1] ) / dis - 1;
            }
            Console.WriteLine(  ans );
        }

        static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
    }
    
}
