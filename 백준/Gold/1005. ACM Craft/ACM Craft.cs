using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Topological_Sort
{

    class BOJ_1005
    {
        static int[] dp;
        static int[] time;
        static int[] degree;
        static List<int>[] listArr;
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string[] inputnk = Console.ReadLine().Split(' ');
                int n = int.Parse(inputnk[0]);
                int k = int.Parse(inputnk[1]);

                string[] inputtime = Console.ReadLine().Split(' ');
                time = new int[1005];
                for (int i = 1; i <= n; i++)
                    time[i] = int.Parse(inputtime[i - 1]);

                listArr = new List<int>[1005];
                dp = new int[1005];
                degree = new int[1005];

                for (int i = 1; i <= k; i++)
                {
                    string[] inputRel = Console.ReadLine().Split(' ');
                    int par = int.Parse(inputRel[0]);
                    int chi = int.Parse(inputRel[1]);
                    if (listArr[par] == null)
                        listArr[par] = new List<int>();
                    listArr[par].Add(chi);
                    degree[chi]++;
                }

                int winnum = int.Parse(Console.ReadLine());
                Queue<int> q = new Queue<int>();
                for (int i = 1; i <= n; i++)
                {
                    if(degree[i] == 0)
                        q.Enqueue(i);
                }

                while (q.Count != 0)
                {
                    int cur = q.Dequeue();
                    if (listArr[cur] == null)
                        continue;
                    foreach (var one in listArr[cur])
                    {
                        dp[one] = Math.Max(dp[one], time[cur] + dp[cur]);
                        degree[one]--;
                        if (degree[one] == 0)
                            q.Enqueue(one);
                    }
                }
                sb.AppendLine((dp[winnum] + time[winnum]).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
