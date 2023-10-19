using System;
using System.Collections.Generic;

namespace TwoPointer
{
    
    class BOJ_20922
    {
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnk[0]);
            int k = int.Parse(inputnk[1]);

            string[] inputarr = Console.ReadLine().Split(' ');
            List<int> inputList = new List<int>();
            for (int i = 0; i < n; i++)
                inputList.Add(int.Parse(inputarr[i]));

            int end = 0;
            int[] countarr = new int[100005];
            int ans = 0;
            countarr[inputList[end]]++;
            for (int start = 0; start < n; start++)
            {
                while (end+1 != n && countarr[inputList[end+1]] < k)
                {
                    end++;
                    countarr[inputList[end]]++;
                }
                ans = Math.Max(ans, end - start + 1);
                countarr[inputList[start]]--;
            }
            Console.WriteLine(ans);
        }
    }
    
}
