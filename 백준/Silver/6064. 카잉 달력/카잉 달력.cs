using System;
using System.Text;
using System.Collections.Generic;
namespace MathAlgorithm
{
    
    class BOJ_6064
    {
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n, m, x, y;
            while(t > 0)
            {
                t--;
                string[] inputArr = Console.ReadLine().Split(' ');
                m = int.Parse(inputArr[0]);
                n = int.Parse(inputArr[1]);
                x = int.Parse(inputArr[2]);
                y = int.Parse(inputArr[3]);
                if (x == m)
                    x = 0;
                if (y == n)
                    y = 0;
                int k = LCM(m, n);
                int ans = -1;
                for (int i = x; i <= k; i += m)
                {
                    if (i == 0)
                        continue;
                    if (i % n == y)
                        ans = i;
                }
                Console.WriteLine( ans );
            }
            
        }
        static int GCD(int a , int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        static int LCM(int a, int b)
        {
            return a / GCD(a, b) * b;
        }
    }
    
}
