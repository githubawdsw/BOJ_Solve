using System;
using System.Collections.Generic;

namespace TwoPointer
{
    
    class BOJ_22862
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

            int ans = 0;
            int oddnumcount = 0;
            if (inputList[0] % 2 == 1)
                oddnumcount++;

            int end = 0;
            for (int start = 0; start < n; start++)
            {
                while (end < n-1 && oddnumcount + inputList[end + 1] % 2 <= k)
                {
                    end++;
                    oddnumcount += inputList[end] % 2;
                }
                ans = Math.Max(ans, end - start - oddnumcount + 1);
                oddnumcount -= inputList[start] % 2;
            }
            Console.WriteLine(ans);
        }
    }
    
}
