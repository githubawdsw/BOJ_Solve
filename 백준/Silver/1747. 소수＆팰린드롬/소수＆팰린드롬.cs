using System;
using System.Collections.Generic;

namespace MathAlgorithm
{
    
    class BOJ_1747
    {
        static void Main(string[] args)
        {
            bool[] check = new bool[1005005];
            List<string> primeList = new List<string>();
            check[1] = true;
            for (int i = 2; i * i<= 1005002; i++)
            {
                if (check[i])
                    continue;
                for (int j = i; j * i <= 1005002; j++)
                    check[i * j] = true;
            }
           
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i <= 1005000; i++)
            {
                if (!check[i])
                    primeList.Add(i.ToString());
            }
            if(n < 10)
            {
                Console.WriteLine(primeList[0]);
                return;
            }
            bool ans = false;
            foreach (var one in primeList)
            {
                for (int i = 0; i < one.Length/2; i++)
                {
                    if (one[i] != one[one.Length - 1 - i])
                    {
                        ans = false;
                        break;
                    }
                    ans = true;
                }
                if (ans)
                {
                    Console.WriteLine(one);
                    return;
                }
            }
        }
    }
    
}
