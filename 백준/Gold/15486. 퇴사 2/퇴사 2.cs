using System;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic
{
    
    class BOJ_15486
    {
        static int n;
        static int[] d = new int[1500005];
        static int[] t = new int[1500005];
        static int[] p = new int[1500005];
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] inputtp = Console.ReadLine().Split(' ');
                int time = int.Parse(inputtp[0]);
                int price = int.Parse(inputtp[1]);
                t[i] = time;
                p[i] = price;
            }

            for (int i = n; i >= 1; i--)
            {
                if (i + t[i] <= n + 1)
                    d[i] = Math.Max(d[i + t[i]] + p[i], d[i + 1]);
                else
                    d[i] = d[i + 1];
            }
            Console.WriteLine(d.Max());
        }
    }
    
}
