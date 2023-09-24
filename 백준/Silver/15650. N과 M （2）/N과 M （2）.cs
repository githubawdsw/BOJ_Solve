using System;
using System.Text;
namespace Back_Tracking
{
    class N_And_M_2_15650
    {
        static int n, m;
        static int[] arr = new int[10];
        static bool[] isused = new bool[10];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] inputvalue = Console.ReadLine().Split(" ");
            n = int.Parse(inputvalue[0]);
            m = int.Parse(inputvalue[1]);

            reculsive(0);
        }

        public static void reculsive(int k)
        {
            if (k == m)
            {
                for (int i = 0; i < m; i++)
                {
                    sb.Append(arr[i] + " ");
                }
                Console.WriteLine(sb);
                sb.Clear();
                return;
            }
            int start = 1;
            if (k != 0)
                start = arr[k - 1] + 1;
            for (int i = start; i <= n; i++)
            {
                if (!isused[i])
                {
                    arr[k] = i;
                    isused[i] = true;
                    reculsive(k + 1);
                    isused[i] = false;
                }
            }
        }
    }
}
