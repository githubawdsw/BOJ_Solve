using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_1676
    {
        static void Main(string[] args)
        {
            int n = 1;
            StringBuilder sb = new StringBuilder();
            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());

                if (n > 1 )
                {
                    bool[] check = new bool[250000];

                    for (int i = 2; i * i <= 2 * n; i++)
                    {
                        if (check[i])
                            continue;
                        for (int j = i; j <= 2 * n; j += i)
                            check[j] = true;
                    }
                    int count = 0;
                    for (int i = n + 1; i <= 2 * n; i++)
                    {
                        if (!check[i])
                            count++;
                    }
                    sb.AppendLine(count.ToString());
                }
                else if ( n == 1)
                    sb.AppendLine(1.ToString());
            }
            Console.WriteLine(sb);
        }
    }
    
}
