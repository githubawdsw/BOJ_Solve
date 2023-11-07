using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    
    class BOJ_1707 
    {
        static List<int>[] arrList;
        static StringBuilder sb = new StringBuilder();
        static int[] color;
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            while (k-- > 0)
            {
                color = new int[20005];
                arrList = new List<int>[20005];
                string[] inputve = Console.ReadLine().Split(' ');
                int v = int.Parse(inputve[0]);
                int e = int.Parse(inputve[1]);
                while (e-- > 0)
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

                bool onlyone = false;
                for (int i = 1; i <= v; i++)
                {
                    if (arrList[i] == null)
                        continue;
                    if (color[i] == 0)
                        color[i] = 1;
                    else
                        continue;
                    bool check = dfs(i);
                    if (check)
                        onlyone = true;
                    else
                    {
                        onlyone = false;
                        break;
                    }
                }
                if(onlyone)
                    sb.AppendLine("YES");
                else
                    sb.AppendLine("NO");
            }
            Console.WriteLine(sb);
        }

        static bool dfs(int node)
        {
            bool check = true;
            foreach (var one in arrList[node])
            {
                if (color[node] == color[one])
                    return false;
                if (color[one] > 0)
                    continue;
                if (color[node] == 1)
                    color[one] = 2;
                else
                    color[one] = 1;
                check = dfs(one);
            }
            if (check)
                return true;
            else
                return false;
        }
    }
    
}
