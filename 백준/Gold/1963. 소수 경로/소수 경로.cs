using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_1963
    {
        static bool[] prime = new bool[10001];
        static void Main(string[] args)
        {
            prime[1] = true;
            for (int i = 2; i * i < 10000; i++)
                for (int j = i; j * i < 10000; j++)
                    prime[j * i] = true;
            
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0) 
            {
                string[] inputse = Console.ReadLine().Split(' ');
                int start = int.Parse(inputse[0]);
                int end = int.Parse(inputse[1]);

                int[] dis = new int[10001];
                dis[end] = -1;
                dis[start] = 1;
                Queue<int> q =new Queue<int>();
                q.Enqueue(start);
                while (q.Count != 0)
                {
                    int cur = q.Dequeue();
                    if(cur == end)
                        break;

                    for (int i = 0; i < 4; i++)
                    {
                        string node = cur.ToString();
                        for (int j = 0; j < 10; j++)
                        {
                            if (i == 0 && j == 0)
                                continue;
                            node = node.Remove(i, 1).Insert(i, j.ToString());
                            int parse = int.Parse(node);
                            if (!prime[parse] && dis[cur] > dis[parse])
                            {
                                dis[parse] = dis[cur] + 1;
                                q.Enqueue(parse);
                            }
                        }
                    }
                }
                if (dis[end] == -1)
                    sb.AppendLine("Impossible");
                else
                    sb.AppendLine((dis[end] - 1).ToString());
            }
            Console.WriteLine(  sb);
        }
    }
    
}
