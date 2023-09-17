using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_4134
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                long n = long.Parse(Console.ReadLine());
                if(n == 1 || n == 0)
                {
                    sb.AppendLine("2");
                    continue;
                }
                for (long i = n; i <= long.MaxValue; i++)
                {
                    bool check = true;
                    for (long j = 2; j * j <= i; j++)
                    {
                        if(i % j == 0)
                        {
                            check = false;
                            break;
                        }
                    }
                    if(check)
                    {
                        sb.AppendLine(i.ToString());
                        break;
                    }
                }
            }
            Console.WriteLine(  sb);
        }
    }
    
}
