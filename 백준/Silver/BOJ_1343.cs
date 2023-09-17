using System;
namespace GreedyAlgorithm
{
    
    class BOJ_1343
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int idx = 0;
            string ans = "";
            while (idx < str.Length)
            {
                int count = 0;
               while(count < 4)
                {
                    if (idx >= str.Length)
                        break;
                    if (str[idx] == '.')
                        break;
                    count++;
                    idx++;
                }
                if (count == 2)
                {
                    ans += 'B';
                    ans += 'B';
                }
                else if (count == 4)
                    for (int i = 0; i < 4; i++)
                        ans += 'A';
                else
                {
                    int temp = 0;
                    if (count == 0)
                        temp = 1;
                    for (int i = idx - count; i < idx + temp; i++)
                        ans += str[i];
                    idx++;
                }
            }

            for (int i = 0; i < ans.Length; i++)
            {
                if(ans[i] == 'X')
                {
                    Console.WriteLine( -1 );
                    return;
                }
            }
            Console.WriteLine( ans);

        }
    }
    
}
