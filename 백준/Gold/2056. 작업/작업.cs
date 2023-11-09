using System;
using System.Collections.Generic;
namespace Topological_Sort
{

    class BOJ_2056
    {
        static int[] time = new int[10005];
        static int[] degree = new int[10005];
        static int[] dp = new int[10005];
        static List<int>[] listArr = new List<int>[10005];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] inputwork = Console.ReadLine().Split(' ');
                time[i] = int.Parse(inputwork[0]);

                for (int j = 2; j < inputwork.Length; j++)
                {
                    int point = int.Parse(inputwork[j]);
                    if (listArr[point] == null)
                        listArr[point] = new List<int>();
                    listArr[point].Add(i);
                    degree[i]++;
                }
            }
            Queue<int> q = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                if (degree[i] == 0)
                    q.Enqueue(i);
                dp[i] = time[i];
            }
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                if (listArr[cur] == null)
                    continue;
                foreach (var one in listArr[cur])
                {
                    degree[one]--;
                    dp[one] = Math.Max(dp[one], dp[cur] + time[one]);
                    if(degree[one] == 0)
                        q.Enqueue(one);
                }
            }

            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                if (ans < dp[i])
                    ans = dp[i];
            }
            Console.WriteLine(ans);
        }
    }
}
