using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon2
{
    
    class BOJ_5430
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                t--;
                string inputP = Console.ReadLine();
                int n = int.Parse(Console.ReadLine());
                string inputString = Console.ReadLine();
                inputString = inputString.Substring(1, inputString.Length - 2);
                string[] inputArr = inputString.Split(',');

                List<int> inputList = new List<int>();
                if (inputString != "")
                {
                    for (int i = 0; i < inputArr.Length; i++)
                        inputList.Add(int.Parse(inputArr[i]));
                }
                else
                    inputList.Add(0);

                int idx = 0;
                int l = 0; int r = n;
                if (inputList[0] == 0)
                    inputList.RemoveAt(0);
                for (int i = 0; i < inputP.Length; i++)
                {
                    if (inputP[i] == 'R')
                        idx = 1 - idx;
                    else
                    {
                        if (idx <= 0)
                            l++;
                        else
                            r--;
                    }
                }
                if (l > r )
                    sb.AppendLine("error");
                else
                {
                    inputList.RemoveRange(0, l);
                    inputList.RemoveRange(r - l, n - r );
                    if (idx > 0)
                        inputList.Reverse();
                    sb.Append("[");
                    for (int i = 0; i < r - l; i++)
                    {
                        sb.Append(inputList[i]);
                        if (i != inputList.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine("]");
                }

            }
            Console.Write(sb);
        }
    }
    
}
