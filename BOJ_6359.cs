using System;
using System.Text;

namespace MathAlgorithm
{
    
    class BOJ_6359
    {
        static void Main(string[] args)
        {
            int t, n;
            t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            while (t > 0)
            {
                t--;
                n = int.Parse(Console.ReadLine());
                bool[] door = new bool[105];

                int count = 1;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j <= n; j += count)
                    {
                        if (door[j] == false)
                            door[j] = true;
                        else
                            door[j] = false;
                    }
                    count++;
                }
                int ans = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (door[i] == true)
                        ans++;
                }
                sb.AppendLine(ans.ToString());
            }
            Console.WriteLine(sb);
        }
    }
    
}
