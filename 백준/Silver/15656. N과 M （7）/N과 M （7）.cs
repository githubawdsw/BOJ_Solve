using System;
using System.IO;
using System.Text;
namespace Back_Tracking
{ 
    class N_And_M_7_15656
    {
        static int n, m;
        static int[] arr = new int[8];
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

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.WriteLine(sb.ToString());
            sw.Close();
        }
        
        
        public static void reculsive(int index )
        {
            if (index == m)
            {
                for (int i = 0; i < m; i++)
                    sb.Append(sortValue[arr[i]] + " ");

                sb.AppendLine();
                return;
            }

            for (int i = 0; i < n; i++)
            {
                arr[index] = i;
                reculsive(index + 1);
            }
        }
        
    }
}
