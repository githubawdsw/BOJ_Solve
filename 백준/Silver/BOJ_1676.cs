using System;

namespace MathAlgorithm
{
    
    class BOJ_1676
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            while(n > 1)
            {
                count += n / 5;
                n /= 5;
            }
            Console.WriteLine(count);
        }
    }
    
}
