using System;
using System.Text;
namespace Back_Tracking
{
    class N_And_M_3_15651
    {
        static int n, m;
        static int[] arr = new int[10];
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            string[] inputvalue = Console.ReadLine().Split(" ");
            n = int.Parse(inputvalue[0]);
            m = int.Parse(inputvalue[1]);

            reculsive(0);
            Console.WriteLine(sb);
        }

        public static void reculsive(int k)
        {
            if (k == m)
            {
                for (int i = 0; i < m; i++)
                {
                    sb.Append(arr[i] + " ");
                }
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                arr[k] = i;
                reculsive(k+1);
            }
        }
    }
}
