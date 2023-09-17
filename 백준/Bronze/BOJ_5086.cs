using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_5086
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                if (n == 0 && m == 0)
                    break;

                if (n > m)
                {
                    if (n % m == 0)
                        sb.AppendLine("multiple");
                    else
                        sb.AppendLine("neither");
                }
                else
                {
                    if (m % n == 0)
                        sb.AppendLine("factor");
                    else
                        sb.AppendLine("neither");
                }
            }
                Console.WriteLine(  sb);
        } 
    }
    
}
