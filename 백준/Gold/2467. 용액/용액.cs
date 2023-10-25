using System;
using System.Collections.Generic;
namespace Binary_Search
{
    class BOJ_2467
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputval = Console.ReadLine().Split(' ');
            List<long> arrList = new List<long>();
            for (int i = 0; i < n; i++)
                arrList.Add(long.Parse(inputval[i]));

            int start = 0;
            int end = n-1;
            Tuple<long, long> ans = new Tuple<long, long>(int.MaxValue,int.MaxValue);
            while (start < end)
            {
                if (Math.Abs(ans.Item1 + ans.Item2) > Math.Abs(arrList[start] + arrList[end]))
                    ans = new Tuple<long, long>(arrList[start], arrList[end]);
                if (Math.Abs(arrList[start] + arrList[end - 1]) <= Math.Abs(arrList[start + 1] + arrList[end]))
                    end--;
                else
                    start++;
            }
            Console.WriteLine($"{ans.Item1} {ans.Item2}");
        }
    }
    
}
