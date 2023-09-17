using System;

namespace MathAlgorithm
{
    
    class BOJ_13241
    {
        static void Main(string[] args)
        {
            string[] inputab = Console.ReadLine().Split(' ');
            long a = long.Parse(inputab[0]);
            long b = long.Parse(inputab[1]);
            long ans = a * b / GCD(a, b);
            Console.WriteLine(  ans);
        }

        static long GCD(long a, long b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
    }
    
}
