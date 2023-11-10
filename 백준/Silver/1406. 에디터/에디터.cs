using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon2
{
    class BOJ_1406
    {
        
        static void Main(string[] args)
        {
            string inputArr = Console.ReadLine();
            LinkedList<string> ll = new LinkedList<string>();
            for (int i = 0; i < inputArr.Length; i++)
                ll.AddLast(inputArr[i].ToString());
            ll.AddLast(" ");

            int m = int.Parse(Console.ReadLine());
            string[] inputCommand;
            LinkedListNode<string> ln = ll.Last;
            for (int i = 0; i < m; i++)
            {
                inputCommand = Console.ReadLine().Split(' ');
                if (inputCommand[0] == "P")
                    ll.AddBefore(ln, inputCommand[1]);
                else if (inputCommand[0] == "L")
                {
                    if (ln.Previous == null)
                        continue;
                    else
                        ln = ln.Previous;
                }
                else if (inputCommand[0] == "D")
                {
                    if (ln.Next == null)
                        continue;
                    else
                        ln = ln.Next;
                }
                else if (inputCommand[0] == "B")
                {
                    if (ln.Previous == null)
                        continue;
                    else
                        ll.Remove( ln.Previous);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var one in ll)
                sb.Append(one);
            
            Console.WriteLine(sb);

        }
    }
        
}
