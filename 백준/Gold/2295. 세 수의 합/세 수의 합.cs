using System;
using System.Collections.Generic;
namespace Binary_Search
{
    
    class BOJ_2295
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> inputlist = new List<int>();
            for (int i = 0; i < n; i++)
                inputlist.Add( int.Parse(Console.ReadLine()));
            inputlist.Sort();

            List<int> two = new List<int>();
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    two.Add(inputlist[i] + inputlist[j]);

            two.Sort();
            for (int i = n-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    int start = 0;
                    int end = two.Count - 1;
                    int mid;
                    while(start <= end)
                    {
                        mid = (start + end) / 2;
                        if (two[mid] == inputlist[i] - inputlist[j])
                        {
                            Console.WriteLine(inputlist[i]);
                            return;
                        }
                        else if (two[mid] < inputlist[i] - inputlist[j])
                            start = mid + 1;
                        else
                            end = mid - 1;
                    }
                }
            }
        }
    }
    
}
