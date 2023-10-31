using System;
using System.Collections.Generic;
using System.Text;
namespace BFS_DFS_Reculsive
{
    class Recursion_11729
    {
        static int N;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            int count = 1;
            for (int i = 0; i < N; i++)
                count *= 2;
            Console.WriteLine(count-1);
            HanoiSpire(N ,1 ,3);
            Console.WriteLine(sb.ToString());
        }
        static void HanoiSpire(int n, int a, int b)
        {
            if (n == 1)
            {
                sb.AppendLine($"{a} {b}");
                return;
            }
            HanoiSpire(n - 1, a, 6 - a - b);
            sb.AppendLine($"{a} {b}");
            HanoiSpire(n - 1, 6 - a - b, b);
        }
    }
}
