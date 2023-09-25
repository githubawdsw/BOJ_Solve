using System;
using System.Text;
namespace Back_Tracking
{
    class N_And_M_4_15652
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

            string[] sequence = Console.ReadLine().Split(" ");
            int[] sortValue = new int[n];
            for (int i = 0; i < n; i++)
            {
                sortValue[i] = int.Parse(sequence[i]);
            }
            Array.Sort(sortValue);

            reculsive( 0 , sortValue);
            Console.WriteLine(sb);
        }

        public static void reculsive(int k , int[] sortValue)
        {
            if (k == m)
            {
                for (int i = 0; i < m; i++)
                {
                    sb.Append(sortValue[arr[i]] + " ");
                }
                sb.AppendLine();
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!isused[i])
                {
                    isused[i] = true;
                    arr[k] = i;
                    reculsive(k+1, sortValue);
                    isused[i] = false;
                }
            }
        }
    }
}
