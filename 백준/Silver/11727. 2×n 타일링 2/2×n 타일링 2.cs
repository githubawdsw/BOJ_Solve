using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    
    class BOJ_11727
    {
        static int N;
        static int[] D = new int[ 1002];
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            D[1] = 1;
            D[2] = 3;
            for (int i = 3; i <= N; i++)
                D[i] = (D[i - 1] + (D[i -2] * 2)) % 10007;
            Console.WriteLine(D[N]); 

        }
    }
        
}
