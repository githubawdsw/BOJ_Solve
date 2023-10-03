using System;
using System.Collections.Generic;
using System.Text;
namespace MathAlgorithm
{
    
    class BOJ_9020
    {
        static void Main(string[] args)
        {
            int t, n;
            t = int.Parse(Console.ReadLine());
            List<int> primeList = new List<int>();
            bool[] check = new bool[10005];
            StringBuilder sb = new StringBuilder();

            for (int i = 2; i < check.Length; i++)
            {
                if (check[i])
                    continue;
                primeList.Add(i);
                for (int j = i; j * i < check.Length; j++)
                    check[j * i] = true;
            }

            while (t > 0)
            {
                t--;
                n = int.Parse(Console.ReadLine());
                int first = 0;
                int second = 0;
                foreach (var one in primeList)
                {
                    if (one > n / 2)
                        break;
                    if (!check[n - one])
                    {
                        first = one;
                        second = n - one;
                    }
                }
                sb.AppendLine($"{first} {second}");
            }
            Console.WriteLine(sb);
        }
    }
    
}
