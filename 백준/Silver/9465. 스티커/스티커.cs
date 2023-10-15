using System;
using System.Collections.Generic;
namespace Dynamic
{
    
    class BOJ_9465
    {
        static int N , T;
        static void Main(string[] args)
        {
            T = int.Parse(Console.ReadLine());
            while (T > 0)
            {
                T--;

                List<List<int>> arr = new List<List<int>>();
                int[,] d = new int[100005, 3];
                N = int.Parse(Console.ReadLine());
                for (int i = 0; i < 2; i++)
                {
                    string[] inpuarr = Console.ReadLine().Split(' ');
                    arr.Add(new List<int>());
                    for (int j = 0; j < N; j++)
                        arr[i].Add(int.Parse(inpuarr[j]));
                    
                }
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int l = 0;
                        if (i > 1)
                            l = Math.Max(d[i - 2, 0], d[i - 2, 1]);
                        if (i > 0)
                            l = Math.Max(l, d[i - 1, 1 - j]);
                        d[i, j] = l + arr[j][i];
                    }
                }
                Console.WriteLine(Math.Max(d[N - 1, 0], d[N - 1, 1]));
            }
            
        }
    }
    
}
