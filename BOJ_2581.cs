using System;

namespace MathAlgorithm
{
    
    class BOJ_2581
    {
        static void Main(string[] args)
        {
            bool[] primeCheck = new bool[10005];
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i * i<= n; i++)
            {
                if (primeCheck[i])
                    continue;
                for (int j = i; i * j <= n; j ++)
                    primeCheck[i * j] = true;
            }

            int sum = 0;
            int min = int.MaxValue;
            for (int i = 2; i <= n; i++)
            {
                if (i >= m && !primeCheck[i])
                {
                    sum += i;
                    min = Math.Min(i, min);
                }
            }
            if(sum != 0)
            {
                Console.WriteLine(  sum);
                Console.WriteLine(  min);
            }
            else
                Console.WriteLine(  -1);
        }

    }
    
}
