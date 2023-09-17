using System;
using System.Text;

namespace GreedyAlgorithm
{
    
    class BOJ_2720
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            int q = 0;
            int d = 0;
            int n = 0;
            int p = 0;

            while (t-- > 0)
            {
                int c = int.Parse(Console.ReadLine());
                q = c / 25;
                c %= 25;
                d = c / 10;
                c %= 10;
                n = c / 5;
                c %= 5;
                p = c;
                sb.AppendLine($"{q} {d} {n} {p}");
            }
            Console.WriteLine( sb );
        }
    }
    
}
