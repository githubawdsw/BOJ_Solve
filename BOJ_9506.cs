using System;
using System.Collections.Generic;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_9506
    {
        static void Main(string[] args)
        {
            int n = 0;
            StringBuilder sb = new StringBuilder();
            while(true)
            { 
                n = int.Parse(Console.ReadLine());
                if (n == -1)
                    break;

                int sum = 0;
                List<int> list = new List<int>();
                sb.Append(n);
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        list.Add(i);
                        sum += i;
                    }
                }
                if (sum == n)
                {
                    sb.Append($" = ");
                    for (int i = 0; i < list.Count; i++)
                    {
                        sb.Append(list[i]);
                        if (i != list.Count - 1)
                            sb.Append(" + ");
                    }
                }
                else
                    sb.Append($" is NOT perfect.");
                sb.AppendLine();
            }
            Console.WriteLine(  sb);
        } 
    }
    
}
