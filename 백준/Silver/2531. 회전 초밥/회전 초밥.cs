using System;
using System.Collections.Generic;

namespace TwoPointer
{
    
    class BOJ_2531
    {
        static void Main(string[] args)
        {
            string[] inputndkc = Console.ReadLine().Split(' ');
            int n = int.Parse(inputndkc[0]);
            int d = int.Parse(inputndkc[1]);
            int k = int.Parse(inputndkc[2]);
            int c = int.Parse(inputndkc[3]);

            List<int> inputList = new List<int>();
            for (int i = 0; i < n; i++)
                inputList.Add(int.Parse(Console.ReadLine()));

            int[] check = new int[3005];
            check[c] = 1;
            int count = 1;
            int ans = 0;
            for (int i = 0; i < k; i++)
            {
                if (check[inputList[i]] == 0)
                    count++;
                check[inputList[i]]++;
                inputList.Add(inputList[i]);
            }
            for (int i = 0; i < n; i++)
            {
                ans = Math.Max(count, ans);
                check[inputList[i]]--;
                if (check[inputList[i]] == 0)
                    count--;
                if (check[inputList[i + k]] == 0)
                    count++;
                check[inputList[i + k]]++;
            }
            Console.WriteLine(ans);
        }
    }
    
}
