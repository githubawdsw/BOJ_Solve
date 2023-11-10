using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon2
{
    
    class BOJ_5397
    {
        
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int T = int.Parse(Console.ReadLine());
            while (T> 0)
            {
                T--;
                string inputArr = Console.ReadLine();
                LinkedList<string> ll = new LinkedList<string>();
                for (int i = 0; i < inputArr.Length; i++)
                    ll.AddLast(inputArr[i].ToString());
                ll.AddLast("");

                LinkedList<string> inputLL = new LinkedList<string>();
                inputLL.AddLast(" ");
                LinkedListNode<string> ln = inputLL.Last;
                foreach (var one in ll)
                {
                    if (one == ">")
                    {
                        if (ln.Next == null)
                            continue;
                        else
                            ln = ln.Next;
                    }
                    else if (one == "<")
                    {
                        if (ln.Previous == null)
                            continue;
                        else
                            ln = ln.Previous;
                    }
                    else if (one == "-")
                    {
                        if (ln.Previous == null)
                            continue;
                        else
                            inputLL.Remove(ln.Previous);
                    }
                    else
                        inputLL.AddBefore(ln , one);
                }
                foreach (var one in inputLL)
                    sb.Append(one);
                sb.AppendLine();
            }
            Console.WriteLine(sb);

        }
    }
    
}
