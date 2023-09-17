using System;
using System.Collections.Generic;
namespace MathAlgorithm
{
    
    class BOJ_2960
    {
        static void Main(string[] args)
        {
            int n ,k;
            string[] inputnk = Console.ReadLine().Split(' ');
            n = int.Parse(inputnk[0]);
            k = int.Parse(inputnk[1]);
            bool[] isRemoved = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                isRemoved[i] = true;
            
            for (int i = 0; i <= n; i++)
            {
                if (!isRemoved[i])
                    continue;
                
                for (int j = i; j <= n; j+= i)
                {
                    if (!isRemoved[j])
                        continue;
                    isRemoved[j] = false;
                    k--;
                    if(k == 0)
                        Console.WriteLine(j);
                }
            }
        }
    }
    
}
