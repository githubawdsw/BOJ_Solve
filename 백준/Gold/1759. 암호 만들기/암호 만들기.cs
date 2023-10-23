using System;
using System.Collections.Generic;
using System.Text;
namespace Back_Tracking
{
    
    class BOJ_1759
    {
        static int l, c;
        static List<string> wordList;
        static int[] arr = new int[17];
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            string[] inputlc = Console.ReadLine().Split(" ");
            l = int.Parse(inputlc[0]);
            c = int.Parse(inputlc[1]);
            string[] inputwords = Console.ReadLine().Split(" ");
            wordList = new List<string>();
            for (int i = 0; i < c; i++)
                wordList.Add(inputwords[i]);
            wordList.Sort();
            recursion(0 ,0 );
            Console.WriteLine(sb);
        }
        static bool aeiou(string x)
        {
            return x == "a" || x == "e" || x == "i" || x == "o" || x == "u";
        }
        static void recursion(int x, int start)
        {
            if (x == l)
            {
                bool flag = false;
                int count1 = 0;
                int count2 = 0;
                for (int i = 0; i < l; i++)
                {
                    if (aeiou(wordList[arr[i]]))
                        count1++;
                    else
                        count2++;
                }
                if (count1 >= 1 && count2 >= 2)
                    flag = true;
                if (flag)
                {
                    for (int i = 0; i < l; i++)
                        sb.Append(wordList[arr[i]]);
                    sb.AppendLine();
                }
            }
            for (int i = start; i < c; i++)
            {
                arr[x] = i;
                recursion(x + 1, i + 1);
            }
        }
    }
    
}
