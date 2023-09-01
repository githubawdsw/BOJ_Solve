using System;
using System.Text;
namespace MathAlgorithm
{
    
    class BOJ_5347
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            while (n > 0)
            {
                n--;
                string[] inputab = Console.ReadLine().Split(' ');
                long a = long.Parse(inputab[0]);
                long b = long.Parse(inputab[1]);

                long LCM = (a * b )/GCD(a , b);
                sb.AppendLine(LCM.ToString());
            }
            Console.WriteLine(sb);
        }

        static long GCD(long a, long b)
        {
            if (b == 0)
                return a;
            return GCD(b, (a % b));
        }
    }
    
}
