using System;
using System.Collections.Generic;
namespace GreedyAlgorithm
{
    
    class BOJ_2012
    {
        static bool[] check = new bool[500005];
        static List<int> list = new List<int>();
        static int[] arr = new int[500005];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            list.Add(-1);
            for (int i = 0; i < n; i++)
            {
                int rank = int.Parse(Console.ReadLine());
                list.Add(rank);
                arr[i + 1] = i + 1;
            }
            list.Sort();
            
            long ans = 0;
            for (int i = 1; i <= n; i++)
                ans += Math.Abs(arr[i] - list[i]);

            Console.WriteLine(  ans);
        }
    }
    
}
