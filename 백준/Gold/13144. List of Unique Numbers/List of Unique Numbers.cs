using System;
using System.Collections.Generic;

namespace TwoPointer
{
    
    class BOJ_13144
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] inputarr = Console.ReadLine().Split(' ');
            List<int> inputList = new List<int>();
            for (int i = 0; i < n; i++)
                inputList.Add(int.Parse(inputarr[i]));
            inputList.Add(0);
            bool[] check = new bool[100005];
            long count = 0;

            check[inputList[0]] = true;
            int end = 0;
            for (int start = 0; start < n; start++)
            {
                while (end < n-1 && !check[inputList[end + 1]])
                {
                    end++;
                    check[inputList[end]] = true;
                }
                count += end - start + 1;
                check[inputList[start]] = false;
            }
            Console.WriteLine(count);
        }
    }
    
}
