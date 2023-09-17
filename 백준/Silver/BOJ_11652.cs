using System;
using System.Collections.Generic;

namespace Sorting
{
    
    class BOJ_11652
    {
        static int N;
        static List<long> inputArr = new List<long>();
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
                inputArr.Add(long.Parse(Console.ReadLine()));
            inputArr.Sort();
            
            int count = 1, maxcount = 0;
            long minValue = inputArr[0] ,  arrval = inputArr[0];
            for (int i = 1; i < N; i++)
            {
                if(inputArr[i] == arrval)
                {
                    count++;
                    if (count == maxcount)
                        minValue = Math.Min(minValue, inputArr[i]);
                    else if (count > maxcount)
                        minValue = inputArr[i];
                }
                else
                {
                    maxcount =Math.Max( count, maxcount);
                    count = 1;
                    arrval = inputArr[i];
                }
            }
            Console.WriteLine(minValue);

        }
    }

}
