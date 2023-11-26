using System;
using System.Collections.Generic;
using System.Text;
namespace Topological_Sort
{
    
    class BOJ_2637
    {
        static int[] dp = new int[105];
        static int[] degree = new int[105];
        static Dictionary<int, int>[] dictArr = new Dictionary<int, int>[105];
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                string[] inputxyk = Console.ReadLine().Split(' ');
                int x = int.Parse(inputxyk[0]);
                int y = int.Parse(inputxyk[1]);
                int k = int.Parse(inputxyk[2]);

                if (dictArr[x] == null)
                    dictArr[x] = new Dictionary<int, int>();
                dictArr[x].Add(y, k);
                degree[y]++;
            }

            Queue<int> q = new Queue<int>();
            q.Enqueue(n);
            dp[n] = 1;
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                if (dictArr[cur] == null)
                    continue;
                foreach (var one in dictArr[cur])
                {
                    degree[one.Key]--;
                    dp[one.Key] += dp[cur] * one.Value;
                    if (degree[one.Key] == 0)
                        q.Enqueue(one.Key);
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (dictArr[i] == null)
                    sb.AppendLine($"{i} {dp[i]}");
            }
            Console.WriteLine(sb);
        }
    }
    
}
