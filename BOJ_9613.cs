using System;
using System.Collections.Generic;

namespace MathAlgorithm
{
    
    class BOJ_9613
    {
        static void Main(string[] args)
        {
            int t, n;
            t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] inputcase = Console.ReadLine().Split(' ');
                n = int.Parse(inputcase[0]);

                List<int> arr = new List<int>();
                if (n == 1)
                {
                    Console.WriteLine(inputcase[1]);
                    t--;
                    continue;
                }
                for (int i = 1; i <= n; i++)
                    arr.Add(int.Parse(inputcase[i]));

                long ans = 0;
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        ans += gcd(arr[i], arr[j]);

                Console.WriteLine(ans);
                t--;
            }
        }
        static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }
    }
    
}
