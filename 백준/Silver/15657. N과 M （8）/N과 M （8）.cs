using System;
using System.Text;
namespace Back_Tracking
{
    class N_And_M_8_15657
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
                sortValue[i] = int.Parse(sequence[i]);

            Array.Sort(sortValue, 0 , n);

            reculsive( 0 );
            Console.Write(sb);
        }
        
        
        public static void reculsive(int index )
        {
            if (index == m)
            {
                for (int i = 0; i < m; i++)
                {
                    sb.Append(sortValue[arr[i]] + " ");
                }
                sb.Append("\n");
                return;
            }

            int start = 0;
            if (index != 0)
                start = arr[index - 1];

            for (int i = start; i < n; i++)
            {
                arr[index] = i;
                reculsive(index + 1);
            }
        }
        
    }
}
