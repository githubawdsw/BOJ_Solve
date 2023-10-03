using System;
using System.Text;
namespace Back_Tracking
{
    
    class Lotto_6603
    {
        static int k;
        static int[] sortValue;
        static int[] arr = new int[14];
        static bool[] isUsed = new bool[14];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputValue = Console.ReadLine().Split(" ");
                k = int.Parse(inputValue[0]);

                if (k == 0)
                    break;

                sortValue = new int[inputValue.Length - 1];

                for (int i = 0; i < inputValue.Length - 1; i++)
                    sortValue[i] = int.Parse(inputValue[i + 1]);

                Array.Sort(sortValue);
                
                reculsive(0, 0);
                sb.Append("\n");
            }
            Console.WriteLine(sb);
            
        }

        public static void reculsive(int index, int start)
        {
            if (index == 6)
            {
                for (int i = 0; i < index; i++)
                {
                    sb.Append(arr[i] + " ");
                }
                sb.Append("\n");
                return;
            }

            for (int i = start; i < k; i++)
            {
                if (!isUsed[i])
                {
                    isUsed[i] = true;
                    arr[index] = sortValue[i];
                    reculsive(index + 1, i);
                    isUsed[i] = false;
                }
            }
        }
    }
}
