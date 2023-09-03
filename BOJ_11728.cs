using System;
using System.IO;
using System.Text;

namespace Sorting
{
    
    class BOJ_11728
    {
        static int n, m;
        static int[] narr, marr , ans;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] inputNM = Console.ReadLine().Split(' ');

            n = int.Parse(inputNM[0]);
            m = int.Parse(inputNM[1]);

            narr = new int[n];
            string[] inputNarr = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                narr[i] = int.Parse(inputNarr[i]);

            marr = new int[m];
            string[] inputMarr = Console.ReadLine().Split(' ');
            for (int i = 0; i < m; i++)
                marr[i] = int.Parse(inputMarr[i]);

            ans = new int[n + m];
            int x = 0, y = 0, z = 0;
            while (x < n && y < m)
            {
                if (narr[x] < marr[y])
                    ans[z++] = narr[x++];
                else
                    ans[z++] = marr[y++];
            }
            while (x < n)
                ans[z++] = narr[x++];
            while ( y < m)
                ans[z++] = marr[y++];

            for (int i = 0; i < ans.Length; i++)
            {
                sb.Append(ans[i]);
                sb.Append(" ");
            }
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.WriteLine(sb.ToString());
            sw.Close();
        }
    }

}
