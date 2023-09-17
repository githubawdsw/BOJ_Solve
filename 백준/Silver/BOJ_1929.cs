using System;
using System.Text;
namespace MathAlgorithm
{
    
    class BOJ_1929
    {
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] inputmn = Console.ReadLine().Split(' ');
            int m = int.Parse(inputmn[0]);
            int n = int.Parse(inputmn[1]);
            bool[] check = new bool[10000005];

            check[1] = true;
            for (int i = 2; i *i  <= n; i++)
            {
                if (check[i] == true)
                    continue;
                for (int j = i; j * i <= n; j++)
                    check[j * i] = true;
            }
            for (int i = m; i <= n; i++)
                if (!check[i])
                    sb.AppendLine(i.ToString());
            Console.WriteLine(sb);
        }
    }
    
}
