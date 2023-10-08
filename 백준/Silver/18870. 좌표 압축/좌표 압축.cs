using System;
using System.Collections.Generic;
using System.Text;
namespace Binary_Search
{
    
    class BOJ_10816
    {
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputX = Console.ReadLine().Split(' ');
            List<int> inputlist = new List<int>();
            for (int i = 0; i < n; i++)
                inputlist.Add(int.Parse(inputX[i]));
            inputlist.Sort();
            List<int> deduplication = new List<int>();

            int arrval = int.MaxValue;
            for (int i = 0; i < n; i++)
                if (inputlist[i] != arrval)
                {
                    deduplication.Add(inputlist[i]);
                    arrval = inputlist[i];
                }

            int idx = 0;
            while (idx < n)
            {
                int start = 0;
                int end = deduplication.Count - 1;
                int mid;

                while (start <= end)
                {
                    mid = (start + end) / 2;
                    if (deduplication[mid] == int.Parse(inputX[idx]))
                    {
                        sb.Append($"{mid} ");
                        break;
                    }
                    else if (deduplication[mid] < int.Parse(inputX[idx]))
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
                idx++;
            }

            Console.WriteLine(sb);
        }
    }
    
}
