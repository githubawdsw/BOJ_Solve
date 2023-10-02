using System;
using System.Collections.Generic;
namespace Binary_Search
{
    
    class BOJ_2805
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            string[] ninput = Console.ReadLine().Split(' ');
            List<int> tree = new List<int>();

            for (int i = 0; i < n; i++)
                tree.Add(int.Parse(ninput[i]));
            tree.Sort();

            long start = 1;
            long end = tree[n - 1];

            while (start <= end)
            {
                long mid = (start + end) / 2;
                long height = 0;

                for (int i = 0; i < n; i++)
                {
                    if (tree[i] - mid >= 0)
                        height += tree[i] - mid;
                }

                if (mid == 0 || height >= m)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            Console.WriteLine(end);
        }
    }
    
}
