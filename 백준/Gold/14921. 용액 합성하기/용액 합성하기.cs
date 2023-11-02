using System;
using System.Collections.Generic;
using System.Linq;
namespace Binary_Search
{
    // 투포인터가 빨라서 투포인터로 풀이
    class BOJ_14921
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputA = Console.ReadLine().Split(' ');
            List<int> arrList = new List<int>();
            for (int i = 0; i < n; i++)
                arrList.Add(int.Parse(inputA[i]));

            int start = 0;
            int end = arrList.Count - 1;
            int ans = int.MaxValue;
            bool sign = false;
            while (start < end)
            {
                int val = arrList[start] + arrList[end];
                if (Math.Abs(val) < Math.Abs(ans))
                    ans = val;
                if (val < 0)
                    start++;
                else
                    end--;
            }

            Console.WriteLine(ans );
        }
    }
    
}
