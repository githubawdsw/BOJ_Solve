using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_9251
    {
        static int[,] d = new int[1005, 1005];
        static void Main(string[] args)
        {
            string firstArr = Console.ReadLine();
            string secondArr = Console.ReadLine();

            for (int i = 1; i <= firstArr.Length; i++)
            {
                for (int j = 1; j <= secondArr.Length; j++)
                {
                    if (firstArr[i - 1] == secondArr[j - 1])
                        d[i, j] = d[i - 1, j - 1] + 1;
                    else
                        d[i, j] = Math.Max(d[i - 1, j], d[i, j - 1]);
                }
            }
            
            Console.WriteLine(d[firstArr.Length, secondArr.Length]);
        }
    }
    
}
