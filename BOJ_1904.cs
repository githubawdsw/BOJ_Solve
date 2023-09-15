using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_1904
    {
        static int n;
        static int[] d = new int[1000005];
        static List<int> coin = new List<int>();
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            n = int.Parse(inputnk[0]);
            d[1] = 1;
            d[2] = 2;
            for (int i = 3; i <= n; i++)
                d[i] = (d[i - 1] + d[i - 2]) % 15746;
            Console.WriteLine(d[n]);
        }
    }
    
}
