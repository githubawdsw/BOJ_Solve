using System;
using System.Collections.Generic;

namespace TwoPointer
{
    
    class BOJ_1806
    {
        static void Main(string[] args)
        {
            string[] inputns = Console.ReadLine().Split(' ');
            int n = int.Parse(inputns[0]);
            int s = int.Parse(inputns[1]);
            string[] narr = Console.ReadLine().Split(' ');
            List<int> nlist = new List<int>();
            for (int i = 0; i < n; i++)
                nlist.Add(int.Parse(narr[i]));

            int start = 0;
            int end = 0;
            int min = int.MaxValue;
            int sum = 0;
            while (start < n && end <= n)
            {
                if(sum < s && end < n)
                {
                    sum += nlist[end];
                    end++;
                }
                else if(sum >= s)
                {
                    sum -= nlist[start];
                    min = Math.Min(end - start , min);
                    start++;
                }
                else
                    break;
                
            }
            if (min == int.MaxValue)
                min = 0;
            Console.WriteLine(min);
        }
    }
    
}
