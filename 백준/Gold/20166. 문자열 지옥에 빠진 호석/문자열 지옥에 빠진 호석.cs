using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Hash
{

    class BOJ_20166
    {
        static string[,] board = new string[15, 15];
        static int[] dx = { 1, 0, -1, 0, 1, -1, 1, -1 };
        static int[] dy = { 0, 1, 0, -1, 1, -1, -1, 1 };
        static int n, m, k;
        static Dictionary<string, int> dic;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] inputnmk = sr.ReadLine().Split(' ');
            n = int.Parse(inputnmk[0]);
            m = int.Parse(inputnmk[1]);
            k = int.Parse(inputnmk[2]);
            dic = new Dictionary<string, int>();
            List<string> inputword = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string inputboard = sr.ReadLine();
                for (int j = 0; j < m; j++)
                    board[i, j] = inputboard[j].ToString();
            }
            for (int i = 0; i < k; i++)
            {
                string inputkey = sr.ReadLine();
                if (!dic.ContainsKey(inputkey))
                    dic.Add(inputkey, 0);
                inputword.Add(inputkey);
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    dfs(i, j, board[i, j]);

            for (int i = 0; i < k; i++)
                sb.AppendLine(dic[inputword[i]].ToString());
            
            sw.WriteLine(sb);
            sw.Close();

        }

        static void dfs(int a, int b, string s)
        {
            if (dic.ContainsKey(s))
                dic[s]++;
            if (s.Length == 5)
                return;
            for (int i = 0; i < 8; i++)
            {
                int nx = (a + dx[i] + n) % n;
                int ny = (b + dy[i] + m) % m;
                dfs(nx, ny, s + board[nx, ny]);
            }
        }
    }

}
