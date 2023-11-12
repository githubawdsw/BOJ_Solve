using System;
namespace MathAlgorithm
{

    class BOJ_3343
    {
        static long N, a, b, c, d , ans = long.MaxValue;
        static void Main(string[] args)
        {
            string[] inputarr = Console.ReadLine().Split(' ');
             N = long.Parse(inputarr[0]);
             a = long.Parse(inputarr[1]);
             b = long.Parse(inputarr[2]);
             c = long.Parse(inputarr[3]);
             d = long.Parse(inputarr[4]);

            if (b * c < a * d)
            {
                long swap = c;
                c = a;
                a = swap;
                swap = d;
                d = b;
                b = swap;
            }

            long acLCM = a * c / GCD(a, c);

            for (long i = 0; i < (acLCM / a); i++)
            {
                long cost = i * b;
                if (N - i * a > 0)
                    cost += (((N - i * a - 1) / c) + 1) * d;
                ans = Math.Min(ans, cost);
            }

            Console.WriteLine(ans);
        }


        static long GCD(long x , long y)
        {
            if (y == 0)
                return x;
            return GCD(y, x % y);
        }
    }
    
}
