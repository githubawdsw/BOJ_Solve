using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    
    class BOJ_5648
    {
        static int N;
        static List<string> inputArr = new List<string>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] Nelement = Console.ReadLine().Split(' ');
            N = int.Parse(Nelement[0]);

            for (int i = 1; i < Nelement.Length; i++)
            {
                if (String.IsNullOrEmpty(Nelement[i]))
                    break;

                string reverse = new string(Nelement[i].Reverse().ToArray());
                inputArr.Add(reverse);
            }
            while (inputArr.Count != N)
            {
                string[] afterInput = Console.ReadLine().Split(' ');
                for (int i = 0; i < afterInput.Length; i++)
                {
                    if (String.IsNullOrEmpty(afterInput[i]))
                        break;

                    string reverse = new string(afterInput[i].Reverse().ToArray());
                    inputArr.Add(reverse);
                }
            }
            List<long> anslist = inputArr.ConvertAll(x => long.Parse(x));
            anslist = anslist.OrderBy(x => x).ToList();

            for (int i = 0; i < inputArr.Count; i++)
            {
                sb.AppendLine(anslist[i].ToString());
            }
            Console.WriteLine(sb);
        }

    }

}