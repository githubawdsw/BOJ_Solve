using System;
using System.Collections.Generic;

namespace TwoPointer
{
    
    class BOJ_2003
    {
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            string[] narr = Console.ReadLine().Split(' ');
            List<int> nlist = new List<int>();
            for (int i = 0; i < n; i++)
                nlist.Add(int.Parse(narr[i]));

            int start = 0;
            int end = 0;
            int sum = 0;
            int count = 0;
            while (start < n && end <= n)
            {
                if (sum < m && end < n)
                {
                    sum += nlist[end];
                    end++;
                }
                else if (sum >= m)
                {
                    sum -= nlist[start];
                    start++;
                }
                else
                    break;
                if (sum == m)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
    
}
