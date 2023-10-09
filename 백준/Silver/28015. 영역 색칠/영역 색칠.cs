using System;
using System.Collections.Generic;
namespace Baekjoon1
{
    
    class BOJ_28015
    {
        static List<int> inputList = new List<int>();
        static int ans = 0;
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split(' ');

                int[] count = new int[3];
                string before = inputArr[0];
                if (before != "0")
                    count[int.Parse(before)]++;

                for (int j = 1; j < m; j++)
                {
                    if (before != inputArr[j])
                        count[int.Parse(inputArr[j])]++;
                    before = inputArr[j];
                    if ((inputArr[j] == "0" || j == m-1 )&& (count[1] != 0  || count[2] != 0))
                    {
                        int min = count[1] > count[2] ? 2 : 1;
                        if (count[1] == 0)
                            min = 2;
                        if (count[2] == 0)
                            min = 1;
                        ans += count[ min];
                        if (count[1] != 0 && count[2] != 0)
                            ans++;
                        count[1] = 0; count[2] = 0;
                    }
                }
            }
            Console.WriteLine(ans);
        }

    }
    
}
