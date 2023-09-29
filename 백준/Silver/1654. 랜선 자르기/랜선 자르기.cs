using System;
namespace Binary_Search
{
    
    class BOJ_1654
    {
        
        static void Main(string[] args)
        {
            string[] inputkn = Console.ReadLine().Split(' ');
            int k = int.Parse(inputkn[0]);
            int n = int.Parse(inputkn[1]);
            int[] arr = new int[10005];

            for (int i = 0; i < k; i++)
                arr[i] = int.Parse( Console.ReadLine());

            Array.Sort(arr , 0 , k);
            long start  = 1;
            long end = arr[k - 1];
            long mid;
            
            while (start <= end)
            {
                mid = (start + end) / 2;
                long cur = 0;
                for (int i = 0; i < k; i++)
                    cur += arr[i] / mid;
                if (cur < n)
                    end = mid - 1;
                else
                    start = mid + 1;
            }

            Console.WriteLine(end);
        }
    }
    
}
