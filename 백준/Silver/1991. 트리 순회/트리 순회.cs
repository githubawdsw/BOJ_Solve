using System;
using System.Collections.Generic;
using System.Text;
namespace Tree
{
    
    class BOJ_1991
    {
        static int[] ans;
        static Dictionary<char, char> lc = new Dictionary<char, char>();
        static Dictionary<char, char> rc = new Dictionary<char, char>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputNode = Console.ReadLine().Split(' ');

                if (inputNode[1] != ".")
                    lc[char.Parse(inputNode[0])] = char.Parse(inputNode[1]);
                if (inputNode[2] != ".")
                    rc[char.Parse(inputNode[0])] = char.Parse(inputNode[2]);
            }

            preorder('A');
            sb.AppendLine();
            inorder('A');
            sb.AppendLine();
            postorder('A');
            Console.WriteLine(sb);
        }
        static void preorder(char node)
        {
            sb.Append($"{node}");
            if (lc.ContainsKey(node))
                preorder(lc[node]);
            if (rc.ContainsKey(node))
                preorder(rc[node]);
        }
        static void inorder(char node)
        {
            if (lc.ContainsKey(node))
                inorder(lc[node]);
            sb.Append($"{node}");
            if (rc.ContainsKey(node))
                inorder(rc[node]);
        }
        static void postorder(char node)
        {
            if (lc.ContainsKey(node))
                postorder(lc[node]);
            if (rc.ContainsKey(node))
                postorder(rc[node]);
            sb.Append($"{node}");
        }
    }
    
}
