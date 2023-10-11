using System;
using System.Collections.Generic;
namespace Graph
{
    
    class BOJ_1389 
    {
        static List<int>[] arrList = new List<int>[105];
        static int[] dis;
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            while (m-- >0)
            {
                string[] friend = Console.ReadLine().Split(' ');
                int p1 = int.Parse(friend[0]);
                int p2 = int.Parse(friend[1]);

                if (arrList[p1] == null)
                    arrList[p1] = new List<int>();
                if (arrList[p2] == null)
                    arrList[p2] = new List<int>();

                arrList[p1].Add(p2);
                arrList[p2].Add(p1);
            }

            int max = int.MaxValue;
            int ans = int.MaxValue;
            Queue<int> q = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                dis = new int[105];
                dis[i] = 1;
                q.Enqueue(i);
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
                int sum = 0;
                for (int j = 1; j <= n; j++)
                    sum += dis[j] - 1;

                if (max > sum)
                {
                    max = sum;
                    ans = i;
                }
            }
            Console.WriteLine(ans);
        }
    }
    
}
