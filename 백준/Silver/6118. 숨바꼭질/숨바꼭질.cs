using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    
    class BOJ_6118 
    {
        static List<int>[] arrList = new List<int>[20005];
        static StringBuilder sb = new StringBuilder();
        static int[] dis;
        static int max = 0;
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            while (m-- > 0)
            {
                string[] trust = Console.ReadLine().Split(' ');
                int p1 = int.Parse(trust[0]);
                int p2 = int.Parse(trust[1]);

                if (arrList[p1] == null)
                    arrList[p1] = new List<int>();
                if (arrList[p2] == null)
                    arrList[p2] = new List<int>();

                arrList[p1].Add(p2);
                arrList[p2].Add(p1);
            }

            
            dis = new int[20005];
            dis[1] = 1;
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                max = Math.Max(max, dis[cur]);
                foreach (var one in arrList[cur])
                {
                    if (dis[one] > 0)
                        continue;
                    dis[one] = dis[cur] + 1;
                    q.Enqueue(one);
                }
            }

            bool minPos = false;
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                if (max == dis[i] && !minPos)
                {
                    sb.Append($"{i} {dis[i] - 1} ");
                    minPos = true;
                }
                if (max == dis[i])
                    count++;
                if (max < dis[i])
                    break;
            }
            sb.Append($"{count}");

            Console.WriteLine(sb);
        }
    }
    
}
