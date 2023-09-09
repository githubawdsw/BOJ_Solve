using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_3036
    {
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputradius = Console.ReadLine().Split(' ');
            int[] inputarr= new int[105];
            for (int i = 0; i < n; i++)
                inputarr[i] = int.Parse(inputradius[i]);

            for (int i = 1; i < n; i++)
                sb.AppendLine($"{inputarr[0] / GCD(inputarr[0], inputarr[i])}/{inputarr[i] / GCD(inputarr[0], inputarr[i])}");

            Console.WriteLine(sb);
        }

        static  int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
    }
    
}
