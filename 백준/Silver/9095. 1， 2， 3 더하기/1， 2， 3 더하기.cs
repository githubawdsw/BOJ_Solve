using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{

    class BOJ_9095
    {
        static int N, T;
        static int[] d = new int[11];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            T = int.Parse(Console.ReadLine());

            d[1] = 1;
            d[2] = 2;
            d[3] = 4;
            for (int i = 4; i < 11; i++)
                d[i] = d[i - 1] + d[i - 2] + d[i - 3];

            while (T != 0)
            {
                T--;
                N = int.Parse(Console.ReadLine());

                sb.AppendLine(d[N].ToString()) ;
            }
            
            Console.WriteLine(sb);
        }
    }
}
