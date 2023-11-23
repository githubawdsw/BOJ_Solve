using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Floyd_Warshall
{
    
    class BOJ_21940
    {
        static void Main(string[] args)
        {
            int[][] d = new int[205][];

            string[] inputnm = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            for (int i = 1; i <= n; i++)
            {
                d[i] = new int[205];
                Array.Fill(d[i], int.MaxValue / 2);
                d[i][i] = 0;
            }
            for (int i = 0; i < m; i++)
            {
                string[] inputabtime = Console.ReadLine().Split(' ');
                int a = int.Parse(inputabtime[0]);
                int b = int.Parse(inputabtime[1]);
                int time = int.Parse(inputabtime[2]);
                d[a][b] = time;
            }

            int friends = int.Parse(Console.ReadLine());
            List<int> homeList = new List<int>();
            string[] inputhome = Console.ReadLine().Split(' ');
            for (int i = 0; i < friends; i++)
                homeList.Add(int.Parse(inputhome[i]));
            
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    for (int k = 1; k <= n; k++)
                        if (d[j][k] > d[j][i] + d[i][k])
                            d[j][k] = d[j][i] + d[i][k];

            int[] disArr = new int[205];
            Array.Fill(disArr, int.MaxValue / 2);
            for (int i = 1; i <= n; i++)
            {
                disArr[i] = 0;
                foreach (var one in homeList)
                    disArr[i] = Math.Max( d[i][one] + d[one][i] ,disArr[i]);
            }

            int target = disArr.Min();
            List<int> ans = new List<int>();
            for (int i = 0; i < disArr.Length; i++)
            {
                if (disArr[i] == target)
                    ans.Add(i);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var one in ans)
                sb.Append($"{one} ");

            Console.WriteLine(sb);
        }
    }
    
}
