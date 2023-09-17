using System;
using System.Collections.Generic;
namespace GreedyAlgorithm
{
    
    class BOJ_2217
    {
        static int n;
        static List<int> inputlope = new List<int>();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                inputlope.Add(int.Parse(Console.ReadLine()));

            inputlope.Sort();
            int ans = 0;
            for (int i = 1; i <= n; i++)
                ans = Math.Max(ans, inputlope[n - i] * i);
            
            Console.WriteLine(ans);
        }
    }
    
}
