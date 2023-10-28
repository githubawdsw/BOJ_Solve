using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Graph
{
    
    class BOJ_2660 
    {
        static List<int>[] arrList = new List<int>[105];
        static int[] dis;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                if (inputarr[0] == "-1" && inputarr[1] == "-1")
                    break;

                int p1 = int.Parse(inputarr[0]);
                int p2 = int.Parse(inputarr[1]);

                if (arrList[p1] == null)
                    arrList[p1] = new List<int>();
                if (arrList[p2] == null)
                    arrList[p2] = new List<int>();

                arrList[p1].Add(p2);
                arrList[p2].Add(p1);
            }
            Queue<int> q = new Queue<int>();
            int[] friend = new int[55];
            for (int i = 1; i <= n; i++)
            {
                dis = new int[55];
                q.Enqueue(i); 
                dis[i] = 1;
                if (arrList[i] == null)
                    continue;
                while (q.Count != 0)
                {
                    int cur = q.Dequeue();
                    foreach (var one in arrList[cur])
                    {
                        if (dis[one] > 0)
                            continue;
                        dis[one] = dis[cur] + 1;
                        q.Enqueue(one);
                    }
                }
                friend[i] = dis.Max() - 1;
            }

            List<int> candidate = new List<int>();
            int point = 1;
            while (point < 52)
            {
                for (int i = 1; i <= n; i++)
                {
                    if(friend[i] == point)
                        candidate.Add(i);
                }
                point++;
                if (candidate.Count != 0)
                    break;
            }

            Console.WriteLine($"{friend[ candidate[0] ]} {candidate.Count}");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < candidate.Count; i++)
                sb.Append($"{candidate[i]} ");
            Console.WriteLine(sb);
        }
    }
    
}
