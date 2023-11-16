using System;
using System.Collections.Generic;
using System.Text;
namespace Dynamic
{
    
    class BOJ_10942
    {
        static StringBuilder sb = new StringBuilder();
        static int[,] d = new int[2005, 2005];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> inputn = new List<string>();
            string[] inputarr = Console.ReadLine().Split(' ');
            inputn.Add("0");
            for (int i = 0; i < inputarr.Length; i++)
            {
                inputn.Add(inputarr[i]);
            }

            for (int i = 1; i <= n; i++)
            {
                d[i, i] = 1;
                if (inputn[i - 1] == inputn[i])
                    d[i - 1, i] = 1;
            }
            for (int i = 2; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    int s = j;
                    int e = j + i;
                    if (inputn[s] == inputn[e] && d[s + 1, e - 1] == 1)
                        d[s, e] = 1;
                }
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                string[] inputSE = Console.ReadLine().Split(' ');
                sb.AppendLine(d[int.Parse(inputSE[0]) , int.Parse(inputSE[1])].ToString());
            }
            Console.WriteLine(sb);
        }
    }
    
}
