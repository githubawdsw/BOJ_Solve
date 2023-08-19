using System;
using System.Collections.Generic;
namespace Baekjoon1
{
    
    class BOJ_28014
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputArr = Console.ReadLine().Split(' ');
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                if (int.Parse(inputArr[i - 1]) <= int.Parse(inputArr[i]))
                    count++;
            }
            Console.WriteLine(count);
        }
    }
    
}
