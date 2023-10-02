using System;
using System.Collections.Generic;
namespace Graph
{
    
    class BOJ_5567
    {
        static List<int>[] arrList = new List<int>[505];
        static bool[] vis = new bool[505];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                int p1 = int.Parse(inputarr[0]);
                int p2 = int.Parse(inputarr[1]);
                if (arrList[p1] == null)
                    arrList[p1] = new List<int>();
                if (arrList[p2] == null)
                    arrList[p2] = new List<int>();
                arrList[p1].Add(p2);
                arrList[p2].Add(p1);
            }
            if(arrList[1] == null)
            {
                Console.WriteLine(0);
                return;
            }
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(new Tuple<int,int>( 1 , 0));
            while (q.Count != 0)
            {
                Tuple<int,int> cur = q.Dequeue();
                if (vis[cur.Item1] || cur.Item2 > 2)
                    continue;
                vis[cur.Item1] = true;
                for (int i = 0; i < arrList[cur.Item1].Count; i++)
                {
                    if (vis[arrList[cur.Item1][i]])
                        continue;
                    q.Enqueue(new Tuple<int, int>(arrList[cur.Item1][i], cur.Item2 + 1));
                }
            }

            int ans = 0;
            for (int i = 0; i <= 500; i++)
            {
                if (vis[i])
                    ans++;
            }
            Console.WriteLine(--ans);
        }
    }
    
}
