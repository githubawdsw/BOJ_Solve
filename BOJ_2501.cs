using System;
using System.Collections.Generic;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_2501
    {
        static int[,] dp = new int[205, 205];
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnk[0]);
            int k = int.Parse(inputnk[1]);

            List<int> list = new List<int>();
            for (int i = 1; i <= n/2; i++)
            {
                if(n % i == 0)
                    list.Add(i);
            }
            list.Add(n);
            if(list.Count < k)
                Console.WriteLine(  0);
            else
                Console.WriteLine(list[k -1]);
        }
    }
    
}
