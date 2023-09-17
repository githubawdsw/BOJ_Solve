using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_1788
    {
        static int n;
        static long[] d = new long[1000005];
        static List<int> coin = new List<int>();
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());

            d[1] = 1;
            for (int i = 2; i <= Math.Abs(n); i++)
                d[i] = (d[i - 2] + d[i - 1]) % 1000000000;

            if (n == 0)
                Console.WriteLine(0);
            else if (n < 0 && Math.Abs(n) % 2 == 0)
                Console.WriteLine(-1);
            else if (n > 0 || Math.Abs(n) % 2 == 1)
                Console.WriteLine(1);
            Console.WriteLine(d[Math.Abs(n)]);
        }
    }
    
}
