using System;
using System.Collections.Generic;
using System.Linq;
namespace Minimum_Spanning_Tree
{
    
    class BOJ_1774
    {
        static List<Tuple<long, int, int>> linkList = new List<Tuple<long, int, int>>();
        static Tuple< int, int>[] coordinate = new Tuple< int, int>[1005];
        static int[] par = new int[1005];
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);
            for (int i = 1; i <= n; i++)
            {
                string[] inputxy = Console.ReadLine().Split(' ');
                int x = int.Parse(inputxy[0]);
                int y = int.Parse(inputxy[1]);
                coordinate[i] = new Tuple<int, int>(x, y);
            }

            int count = 0;
            for (int i = 0; i < m; i++)
            {
                string[] inputlinked = Console.ReadLine().Split(' ');
                int p1 = int.Parse(inputlinked[0]);
                int p2 = int.Parse(inputlinked[1]);
                if(merge(p1, p2))
                    count++;
            }
            long length = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i+1; j <= n; j++)
                {
                    long dx = Math.Abs(coordinate[i].Item1 - coordinate[j].Item1);
                    long dy = Math.Abs(coordinate[i].Item2 - coordinate[j].Item2);
                    length = dx * dx + dy * dy;
                    linkList.Add(new Tuple<long, int, int>(length, i, j));
                }
            }
            linkList.Sort();
            double ans = 0;
            foreach (var one in linkList)
            {
                if (!merge(one.Item2, one.Item3))
                    continue;
                ans += Math.Sqrt(one.Item1);
                count++;
                if (count == n - 1)
                    break;
            }
            Console.WriteLine(String.Format("{0:0.00}" , ans));
        }
        static bool merge(int x, int y)
        {
            x = find(x); y = find(y);
            if (x == y)
                return false;
            if (par[x] == par[y])
                par[x]--;
            if (par[x] < par[y])
                par[y] = x;
            else
                par[x] = y;
            return true;
        }
        static int find(int x)
        {
            if (par[x] <= 0)
                return x;
            return par[x] = find(par[x]);
        }
    }
    
}
