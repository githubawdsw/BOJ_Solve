using System;

namespace MathAlgorithm
{
    
    class BOJ_2004
    {
        static void Main(string[] args)
        {
            string[] inputval = Console.ReadLine().Split(' ');
            long n = long.Parse(inputval[0]);
            long m = long.Parse(inputval[1]);

            long two = Find(n, 2) - Find(m, 2) - Find(n - m, 2);
            long five = Find(n, 5) - Find(m, 5) - Find(n - m, 5);

            Console.WriteLine($"{Math.Min(two, five)}");
        }

        static long Find(long num, int p)
        {
            long val = 0;
            long divide = p;
            while (num / divide != 0)
            {
                val += (num / divide);
                divide *= p;
            }
            return val;
        }
    }
    
}
