using System;

namespace MathAlgorithm
{
    
    class BOJ_13909
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i * i <= n; i++)
                count++;
            Console.WriteLine(  count);
        }
    }
    
}
