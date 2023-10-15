using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_4883
    {
        static int n;
        static int[,] arr = new int[100005, 5];
        static int[,] d = new int[100005,5];
        static List<int> coin = new List<int>();
        static void Main(string[] args)
        {
            int k = 1;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                    break;

                for (int i = 0; i < n; i++)
                {
                    string[] inputarr = Console.ReadLine().Split(' ');
                    arr[i, 1] = int.Parse(inputarr[0]);
                    arr[i, 2] = int.Parse(inputarr[1]);
                    arr[i, 3] = int.Parse(inputarr[2]);
                }

                d[0, 1] =1000000;
                d[0, 2] = arr[0, 2];
                d[0, 3] = arr[0, 2] + arr[0, 3];
                for (int i = 1; i < n; i++)
                {
                    d[i, 1] = Math.Min(d[i - 1, 1], d[i - 1, 2]) + arr[i, 1];
                    d[i, 2] = Math.Min(d[i - 1, 1], d[i - 1, 2]) + arr[i, 2];
                    d[i, 2] = Math.Min(d[i, 2], d[i - 1, 3] + arr[i, 2]);
                    d[i, 2] = Math.Min(d[i, 2], d[i,1] + arr[i,2]);
                    d[i, 3] = Math.Min(d[i - 1, 2], d[i - 1, 3]) + arr[i, 3];
                    d[i, 3] = Math.Min(d[i,3], d[i,2] + arr[i, 3]);
                }

                Console.WriteLine($"{k}. {d[n-1, 2]}");
                k++;
            }

            
        }
    }
    
}
