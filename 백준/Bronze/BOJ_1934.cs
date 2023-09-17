using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_1934
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string[] ab = Console.ReadLine().Split(' ');
                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);
                int ans = (a* b )/ GCD(a, b);
                sb.AppendLine(ans.ToString());
            }
            Console.WriteLine(  sb);
        } 
        static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
    }
    
}
