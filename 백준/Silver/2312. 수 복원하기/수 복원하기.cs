using System;
using System.Collections.Generic;
using System.Text;
namespace MathAlgorithm
{
    
    class BOJ_2312
    {
        static void Main(string[] args)
        {
            long t, n;
            t = int.Parse(Console.ReadLine());
            bool[] check = new bool[1000002];
            List<long> primeList = new List<long>();
            StringBuilder sb = new StringBuilder();

            for (long i = 2; i  < check.Length; i++)
            {
                if (check[i] == true)
                    continue;
                primeList.Add(i);
                for (long j = i; j * i < check.Length; j++)
                    check[j * i] = true;
            }

            while (t > 0)
            {
                t--;
                n = int.Parse(Console.ReadLine());
                foreach (var one in primeList)
                {
                    int count = 0;
                    while (true)
                    {
                        if (n % one != 0)
                            break;
                        else
                        {
                            n /= one;
                            count++;
                        }
                    }
                    if (count != 0)
                        sb.AppendLine($"{one} {count}");
                }
                
            }
            Console.WriteLine(sb);
        }
    }
    
}
