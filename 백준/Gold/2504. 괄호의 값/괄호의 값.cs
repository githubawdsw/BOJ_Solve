using System;
using System.Collections.Generic;
namespace Baekjoon2
{
    
    class BOJ_2504
    {
        static void Main(string[] args)
        {
            string inputBracket = Console.ReadLine();
            Stack<char> s = new Stack<char>();

            int sum = 0;
            int mul = 1;
            char prev = ' ';
            for (int i = 0; i < inputBracket.Length; i++)
            {
                
                if (inputBracket[i] == '(' )
                {
                    mul *= 2;
                    s.Push(inputBracket[i]);
                }
                else if ( inputBracket[i] == '[')
                {
                    mul *= 3;
                    s.Push(inputBracket[i]);
                }

                else if(s.Count != 0)
                {
                    char cur = s.Pop();
                    if (cur == '(' && inputBracket[i] == ')')
                    { 
                        if (prev == '(')
                            sum += mul;
                        mul /= 2;
                    }
                    else if (cur == '[' && inputBracket[i] == ']')
                    {
                        if (prev == '[')
                            sum += mul;
                        mul /= 3;
                    }
                    else
                    {
                        Console.WriteLine(0);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine(0);
                    return;
                }
                prev = inputBracket[i];
            }
            if(s.Count == 0)
                Console.WriteLine(sum);
            else
                Console.WriteLine(0);
        }
    }
    
}
