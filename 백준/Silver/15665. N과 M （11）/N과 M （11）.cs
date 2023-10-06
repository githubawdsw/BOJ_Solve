using System;
using System.Text;
using System.Collections.Generic;
namespace Back_Tracking
{
    class N_And_M_11_15665
    {
        static int n, m;
        static int[] arr = new int[9];
        static StringBuilder sb = new StringBuilder();
        static int[] sortValue;
        static void Main(string[] args)
        {
            string[] inputvalue = Console.ReadLine().Split(" ");
            n = int.Parse(inputvalue[0]);
            m = int.Parse(inputvalue[1]);

            string[] sequence = Console.ReadLine().Split(" ");
            sortValue = new int[n];

            for (int i = 0; i < n; i++)
            {
                sortValue[i] = int.Parse(sequence[i]);
            }

            Array.Sort(sortValue, 0, n);

            reculsive( 0 ,0 );
            Console.Write(sb);
        }
        
        
        public static void reculsive(int index , int start )
        {
            if (index == m)
            {
                for (int i = 0; i < m; i++)
                {
                    sb.Append(arr[i] + " ");
                }
                sb.Append("\n");
                return;
            }

            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (temp != sortValue[i])
                {
                    arr[index] = sortValue[i];
                    temp = arr[index];
                    reculsive(index + 1 , i +1);
                }
            }
        }
        
    }
}
