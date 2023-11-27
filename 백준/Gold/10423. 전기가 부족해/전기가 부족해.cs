using System;
using System.Collections.Generic;
using System.Linq;
namespace Minimum_Spanning_Tree
{

    class BOJ_10423
    {
        static List<Tuple<int, int, int>> list = new List<Tuple<int, int, int>>();
        static int[] par = new int[1005];
        static string[] powerPlant;
        static void Main(string[] args)
        {
            string[] inputnmk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnmk[0]);
            int m = int.Parse(inputnmk[1]);
            int k = int.Parse(inputnmk[2]);

            Array.Fill(par, -1);
            powerPlant = Console.ReadLine().Split(' ');
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                is_diff_group(0, int.Parse(powerPlant[i]));
                count++;
            }

            for (int i = 0; i < m; i++)
            {
                string[] cable = Console.ReadLine().Split(' ');
                int p1 = int.Parse(cable[0]);
                int p2 = int.Parse(cable[1]);
                int cost = int.Parse(cable[2]);
                list.Add(new Tuple<int, int, int>(cost, p1, p2));
            }
            list.Sort();

            int ans = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var cur = list[i];
                if (!is_diff_group(cur.Item2, cur.Item3))
                    continue;
                ans += cur.Item1;
                count++;
                if (count == n)
                    break;
            }
            Console.WriteLine(ans);
        }
        static bool is_diff_group(int a, int b)
        {
            a = parFind(a); b = parFind(b);
            if (a == b )
                return false;
            if (par[a] == par[b])
                par[a]--;
            if (par[a] < par[b])
                par[b] = a;
            else
                par[a] = b;
            return true;
        }

        static int parFind(int x)
        {
            if (par[x] < 0)
                return x;
            return par[x] = parFind(par[x]);
        }
    }
}
