using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_1011
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            while (t > 0)
            {
                t--;
                string[] inputxy = Console.ReadLine().Split(' ');
                int x = int.Parse(inputxy[0]);
                int y = int.Parse(inputxy[1]);
                int dis = y - x;

                if (dis == 1)
                    sb.AppendLine(dis.ToString());
                else
                {
                    int ans = (int)(Math.Sqrt(dis) * 2 -1e-9);
                    sb.AppendLine(ans.ToString());
                }

            }
            Console.WriteLine(sb);
        }
    }
    
}
