using System;
using System.Collections.Generic;

namespace Graph
{
    
    class BOJ_1043
    {
        static bool[] truth = new bool[55];
        static int n;
        static void Main(string[] args)
        {
            string[] inputnm = Console.ReadLine().Split(' ');
            n = int.Parse(inputnm[0]);
            int m = int.Parse(inputnm[1]);

            List<int>[] linkList = new List<int>[55];
            List<int>[] partyList = new List<int>[55];
            string[] inputTruth = Console.ReadLine().Split(' ');
            for (int i = 1; i <= int.Parse(inputTruth[0]); i++)
                truth[int.Parse(inputTruth[i])] = true;

            for (int i = 1; i <= m; i++)
            {
                string[] inputParty = Console.ReadLine().Split(' ');
                int amount = 1;
                partyList[i] = new List<int>();
                int before = int.Parse(inputParty[1]);
                int next;
                partyList[i].Add(before);
                while (++amount <= int.Parse(inputParty[0]))
                {
                    next = int.Parse(inputParty[ amount]);
                    partyList[i].Add(next);
                    if (linkList[before] == null)
                        linkList[before] = new List<int>();
                    if (linkList[next] == null)
                        linkList[next] = new List<int>();
                    linkList[before].Add(next);
                    linkList[next].Add(before);
                    before = next;
                }
            }

            Queue<int> q = new Queue<int>();
            for (int i = 1; i <= n; i++)
                if (truth[i] && linkList[i] != null)
                    q.Enqueue(i);
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                foreach (var one in linkList[cur])
                {
                    if (truth[one])
                        continue;
                    truth[one] = true;
                    q.Enqueue(one);
                }
            }
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                bool know = false;
                foreach (var one in partyList[i])
                    if (truth[one])
                        know = true;
                if (!know)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
    
}
