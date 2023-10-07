using System;
using System.Collections.Generic;
using System.Text;
namespace MathAlgorithm
{
    
    class BOJ_17103
    {
        static void Main(string[] args)
        {
            int t, n;
            t = int.Parse(Console.ReadLine());
            bool[] check = new bool[1000002];
            List<long> primeList = new List<long>();
            StringBuilder sb = new StringBuilder();

            for (long i = 2; i * i < check.Length; i++)
            {
                if (check[i] == true)
                    continue;
                for (long j = i; j * i < check.Length; j++)
                    check[j * i] = true;
            }
            for (int i = 2; i < check.Length; i++)
            {
                if(check[i] == false)
                    primeList.Add(i);
            }

            while (t > 0)
            {
                t--;
                n = int.Parse(Console.ReadLine());
                int ans = 0;
                foreach (var one in primeList) 
                {
                    if (one > n / 2)
                        break;
                    if (check[n - one] == false)
                        ans++;
                }
                sb.AppendLine(ans.ToString());
            }
            Console.WriteLine(sb);
        }
    }
    
}
