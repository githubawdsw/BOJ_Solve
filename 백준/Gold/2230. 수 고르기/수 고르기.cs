using System;
using System.Collections.Generic;

namespace TwoPointer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            List<int> nlist = new List<int>();
            for (int i = 0; i < n; i++)
                nlist.Add(int.Parse(Console.ReadLine()));

            nlist.Sort();
            int start = 0;
            int end = 0;
            int min = int.MaxValue;
            while (start < n-1 && end < n)
            {
                int sub = nlist[end] - nlist[start];
                if( sub < m)
                    end++;
                else
                {
                    min = Math.Min( sub, min);
                    start++;
                }
            }
            Console.WriteLine(min);
        }
    }
}
