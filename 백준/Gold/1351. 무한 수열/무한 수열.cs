using System;
using System.Collections.Generic;
using System.IO;
namespace Hash
{

    class BOJ_1351
    {
        static int p, q;
        static Dictionary<long, long> dic = new Dictionary<long, long>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            string[] inputnpq = sr.ReadLine().Split(' ');
            long n = long.Parse(inputnpq[0]);
            p = int.Parse(inputnpq[1]);
            q = int.Parse(inputnpq[2]);

            dic.Add(0, 1);
            long ans = recursive(n);
            sw.WriteLine(ans);
            sw.Close();
        }
        static long recursive(long n)
        {
            if (dic.ContainsKey(n))
                return dic[n];
            else
                dic.Add(n, recursive(n / p) + recursive(n / q));
            return dic[n];
        }
    }

}
