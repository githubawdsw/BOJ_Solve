using System;
using System.Collections.Generic;
namespace Binary_Search
{

    class BOJ_1253
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputA = Console.ReadLine().Split(' ');
            List<int> arrList = new List<int>();
            for (int i = 0; i < n; i++)
                arrList.Add(int.Parse(inputA[i]));
            arrList.Sort();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int start = 0;
                int end = n - 1;
                while (start < end)
                {
                    if (arrList[start] + arrList[end] > arrList[i] || end == i)
                        end--;
                    else if (arrList[start] + arrList[end] < arrList[i] || start == i)
                        start++;
                    else
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine( count);
        }
    }
    
}
