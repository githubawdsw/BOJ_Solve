using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace BinarySearchTree
{
    
    class BOJ_21939
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            Dictionary<int, SortedSet<int>> ssdict = new Dictionary<int, SortedSet<int>>();
            Dictionary<int, int> PpairL = new Dictionary<int, int>();

            int n = int.Parse(sr.ReadLine());
            while (n-- >0)
            {
                string[] inputPL = sr.ReadLine().Split(' ');
                int p = int.Parse(inputPL[0]);
                int l = int.Parse(inputPL[1]);
                if (!ssdict.ContainsKey(l))
                    ssdict[l] = new SortedSet<int>();
                ssdict[l].Add(p);

                if (!PpairL.ContainsKey(p))
                    PpairL[p] = l;
            }

            int m = int.Parse(sr.ReadLine());
            while (m-- > 0)
            {
                string[] command = sr.ReadLine().Split(' ');

                if (command[0] == "add")
                {
                    int p = int.Parse(command[1]);
                    int l = int.Parse(command[2]);
                    if (!ssdict.ContainsKey(l))
                        ssdict[l] = new SortedSet<int>();
                    ssdict[l].Add(p);

                    if (!PpairL.ContainsKey(p))
                        PpairL[p] = l;
                }

                else if (command[0] == "recommend")
                {
                    if(command[1] == "1")
                        sb.AppendLine(ssdict[ssdict.Keys.Max()].Max.ToString());
                    else if (command[1] == "-1")
                        sb.AppendLine(ssdict[ssdict.Keys.Min()].Min.ToString());
                }

                else
                {
                    int solveP = int.Parse(command[1]);
                    ssdict[PpairL[solveP]].Remove(solveP);
                    if (ssdict[PpairL[solveP]].Count == 0)
                        ssdict.Remove(PpairL[solveP]);
                    PpairL.Remove(solveP);
                }
            }

            Console.WriteLine(sb);
        }
    }
    
}