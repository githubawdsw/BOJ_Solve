using System;
using System.Collections.Generic;
using System.IO;
namespace Binary_Search
{
    
    class BOJ_2512
    {
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static void Main(string[] args)
        {
            int n = int.Parse(sr.ReadLine());
            string[] inputBudget = sr.ReadLine().Split(' ');

            List<int> inputList = new List<int>();
            for (int i = 0; i < n; i++)
                inputList.Add(int.Parse(inputBudget[i]));
            inputList.Sort();

            int m = int.Parse(sr.ReadLine());

            int start = 0;
            int end = inputList[n - 1];
            int ans = 0;
            while (start<=end)
            {
                int mid = (start + end) / 2;
                int sum = 0;
                for (int i = 0; i < n; i++)
                    sum += Math.Min(inputList[i], mid);
                if (m >= sum)
                {
                    start = mid + 1;
                    ans = mid;
                }
                else
                    end = mid - 1;
            }
            Console.WriteLine(ans);

        }
    }    
    
}
