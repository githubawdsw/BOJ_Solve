using System;
using System.Collections.Generic;
using System.Text;
namespace Back_Tracking
{
    
    class BOJ_16987
    {
        static int n ,count = 0 , max = 0;
        static int[] sarr = new int[10];
        static int[] warr = new int[10];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputSW = Console.ReadLine().Split(" ");
                int s = int.Parse(inputSW[0]);
                int w = int.Parse(inputSW[1]);
                sarr[i] = s;
                warr[i] = w;
            }
            recursion(0);
            Console.WriteLine(max);
        }

        static void recursion(int x)
        {
            if( x == n)
            {
                max = Math.Max(max, count);
                return;
            }

            if (sarr[x] <= 0 || count == n - 1)
            {
                recursion(x + 1);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (i == x || sarr[i] <= 0)
                    continue;
                sarr[x] -= warr[i];
                sarr[i] -= warr[x];
                if (sarr[i] <= 0)
                    count++;
                if (sarr[x] <= 0)
                    count++;

                recursion(x + 1);

                if (sarr[i] <= 0)
                    count--;
                if (sarr[x] <= 0)
                    count--;
                sarr[x] += warr[i];
                sarr[i] += warr[x];
            }
        }
    }
    
}
