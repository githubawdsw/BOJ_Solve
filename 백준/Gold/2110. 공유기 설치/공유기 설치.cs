using System;
using System.Collections.Generic;
using System.IO;
namespace Binary_Search
{

    class BOJ_2110
    {
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static List<int> houseList = new List<int>();
        static int n, c;

        static void Main(string[] args)
        {
            string[] inputnc = sr.ReadLine().Split(' ');
            n = int.Parse(inputnc[0]);
            c = int.Parse(inputnc[1]);

            for (int i = 0; i < n; i++)
                houseList.Add(int.Parse(sr.ReadLine()));
            houseList.Sort();

            int left = 1;
            int right = houseList[n-1];
            int ans = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int count = 1;
                int start = houseList[0];
                for (int i =1; i < n; i++)
                {
                    if (houseList[i] - start >= mid)
                    {
                        start = houseList[i];
                        count++;
                    }

                }
                if (count >= c)
                {
                    ans = mid;
                    left = mid + 1;
                }
                else
                    right = mid - 1;
            }

            Console.WriteLine(ans);
        }
        
    }    
    
}
