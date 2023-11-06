
using System;
using System.Collections.Generic;
using System.IO;
namespace Binary_Search
{
    
    class BOJ_1477
    {
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static void Main(string[] args)
        {
            string[] inputnml = sr.ReadLine().Split(' ');
            int n = int.Parse(inputnml[0]);
            int m = int.Parse(inputnml[1]);
            int l = int.Parse(inputnml[2]);

            
            string[] restingPos = sr.ReadLine().Split(' ');
            List<int> posList = new List<int>();
            for (int i = 0; i < n; i++)
                posList.Add(int.Parse(restingPos[i]));
            posList.Add(l);
            posList.Sort();

            int start = 1;
            int end = l;
            while (start<=end)
            {
                int mid = (start + end) / 2;
                int count = 0;
                int pre = 0;
                for (int i = 0; i <= n; i++)
                {
                    int dis = posList[i] - pre;
                    if(dis >= mid)
                    {
                        if (dis % mid != 0)
                            count += dis / mid;
                        else
                            count += (dis / mid - 1);
                    }
                    pre = posList[i];
                }
                if (count > m)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            Console.WriteLine(start);
        }
    }    
    
}
