using System;
using System.Collections.Generic;

namespace TwoPointer
{
    
    class BOJ_1940
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[] inputnumber = Console.ReadLine().Split(' ');
            
            List<int>list = new List<int>();
            for (int i = 0; i < n; i++)
                list.Add(int.Parse(inputnumber[i]));
            list.Sort();

            int left = 0;
            int right = list.Count - 1;
            int ans = 0;
            while (left < right)
            {
                if (list[left] + list[right] == m)
                {
                    ans++;
                    left++;
                    right--;
                }
                else if (list[left] + list[right] < m)
                    left++;
                else
                    right--;
            }

            Console.WriteLine(  ans );
        }
    }
    
}
