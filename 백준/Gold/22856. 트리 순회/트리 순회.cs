using System;
using System.Collections.Generic;
using System.Text;
namespace Tree
{
    
    class BOJ_22856
    {
        static bool[] vis = new bool[100005];
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] par = new int[100005];
            int[] left = new int[100005];
            int[] right = new int[100005];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputabc = Console.ReadLine().Split(' ');
                int a = int.Parse(inputabc[0]);
                int b = int.Parse(inputabc[1]);
                int c = int.Parse(inputabc[2]);
                if(b != -1)
                    par[b] = a;
                if (c != -1)
                    par[c] = a;
                right[a] = c;
                left[a] = b;
            }
            int endpos = 1;
            while (right[endpos] != -1)
                endpos = right[endpos];

            int cur = 1;
            int ans = 0;
            while (true)
            {
                ans++;
                if(cur != -1)
                    vis[cur] = true;
                if (left[cur] != -1 && !vis[left[cur]])
                    cur = left[cur];
                else if (right[cur] != -1 && !vis[right[cur]])
                    cur = right[cur];
                else
                {
                    if (cur == endpos)
                        break;
                    else
                        cur = par[cur];
                }
            }
            Console.WriteLine(ans -1 );
        }
    }
    
}
