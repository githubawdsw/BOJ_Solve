using System;
using System.Collections.Generic;
using System.Text;
namespace Topological_Sort
{
    class BOJ_2252
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            List<int>[] list = new List<int>[32005];
            Queue<int> q = new Queue<int>();
            int[] degree = new int[32005];
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            while (m-- > 0)
            {
                string[] inputnum = Console.ReadLine().Split(' ');
                int front = int.Parse(inputnum[0]);
                int back = int.Parse(inputnum[1]);
                if (list[front] == null)
                    list[front] = new List<int>();
                list[front].Add(back);
                degree[back]++;
            }

            for (int i = 1; i <= n; i++)
            {
                if (degree[i] == 0)
                    q.Enqueue(i);
            }
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                sb.Append($"{cur} ");
                if (list[cur] == null)
                    continue;
                foreach (var one in list[cur])
                {
                    degree[one]--;
                    if(degree[one] == 0)
                        q.Enqueue(one);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
