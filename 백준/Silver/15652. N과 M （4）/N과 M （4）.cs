using System;
using System.Text;
namespace Back_Tracking
{
    class N_And_M_4_15652
    {
        static int n, m;
        static int[] arr = new int[10];
        static StringBuilder sb = new StringBuilder();
        static bool flag = false;

        static void Main(string[] args)
        {
            string[] inputvalue = Console.ReadLine().Split(" ");
            n = int.Parse(inputvalue[0]);
            m = int.Parse(inputvalue[1]);

            reculsive(0, 0);
            Console.WriteLine(sb);
        }

        public static void reculsive(int beforeNum,int k)
        {
            if (k == m )
            {
                for (int i = 0; i < m; i++)
                {
                    sb.Append(arr[i] + " ");
                }
                sb.AppendLine();
                return;
            }
            int start = 1;
            if (k != 0)
                start = arr[k - 1];
            for (int i = start; i <= n; i++)
            {
                arr[k] = i;
               
                reculsive(k,k + 1);
            }

        }
    }
}
