using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Minimum_Spanning_Tree
{
    
    class BOJ_1647
    {
        static List<Tuple<int, int, int>> pathList = new List<Tuple<int, int, int>>();
        static int[] par = new int[100005];
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            

            for (int i = 0; i < m; i++)
            {
                string[] inputabc = Console.ReadLine().Split(' ');
                int a = int.Parse(inputabc[0]);
                int b = int.Parse(inputabc[1]);
                int cost = int.Parse(inputabc[2]);
                pathList.Add(new Tuple<int, int, int>( cost, a, b));
            }
            pathList.Sort();

            if (m == 1)
            {
                Console.WriteLine(0);
                return;
            }

            long ans = 0;
            int count = 0;
            for (int i = 0; i < pathList.Count; i++)
            {
                int v1 = pathList[i].Item2;
                int v2 = pathList[i].Item3;
                int cost = pathList[i].Item1;
                if (!is_diff_group(v1, v2))
                    continue;
                ans += cost;
                count++;
                if (count == n - 2)
                    break;
            }
            Console.WriteLine(  ans );

        }
        static bool is_diff_group(int a, int b)
        {
            a = find(a); b = find(b);
            if(a == b) 
                return false;
            if (par[a] == par[b])
                par[a]--;
            if (par[a] < par[b])
                par[b] = a;
            else
                par[a] = b;
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
