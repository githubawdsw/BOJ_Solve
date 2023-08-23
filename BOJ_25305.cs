using System;
using System.Collections.Generic;
namespace Baekjoon1
{
    
    class BOJ_25305
    {
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnk[0]);
            int k = int.Parse(inputnk[1]);

            string[] inputX = Console.ReadLine().Split(' ');
            List<int> X = new List<int>();
            for (int i = 0; i < inputX.Length; i++)
                X.Add(int.Parse(inputX[i]));
            X.Sort();
            Console.WriteLine(X[n -k]);
        }
    }
    
}
