using System;
using System.Collections.Generic;
namespace Baekjoon2
{
    
    class BOJ_10799
    {
        static void Main(string[] args)
        {
            string inputBracket = Console.ReadLine();
            Stack<char> s = new Stack<char>();

            long ans = 0;
            for (int i = 0; i < inputBracket.Length; i++)
            {
                if (inputBracket[i] == '(')
                    s.Push(inputBracket[i]);
                else
                {
                    if(inputBracket[i-1] == '(')
                    {
                        s.Pop();
                        ans += s.Count;
                    }
                    else
                    {
                        s.Pop();
                        ans++;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
    
}
