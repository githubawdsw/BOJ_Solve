using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_10250
    {
        static void Main(string[] args)
        {
            int t, h, w, n;
            t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            while (t > 0)
            {
                t--;
                string[] inputhwn = Console.ReadLine().Split(' ');
                h = int.Parse(inputhwn[0]);
                w = int.Parse(inputhwn[1]);
                n = int.Parse(inputhwn[2]);

                int col = 1;
                int floor = 1;
                for (int i = 1; i <= w; i++)
                {
                    if (h * i >= n)
                    {
                        col = i;
                        floor = n - h*(i - 1);
                        break;
                    }
                }
                if (col / 10 == 0)
                    floor *= 10;
                sb.AppendLine($"{floor}{col}");
            }
            Console.WriteLine(sb);
        }
    }
    
}
