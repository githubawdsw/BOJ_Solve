using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Formats.Asn1;
using System.Net;

class DPQ
{
    public class DblEndedPQ
    {
        private PriorityQueue<int, int> minQueue;
        private PriorityQueue<int, int> maxQueue;
        private Dictionary<int, int> entries;
        public DblEndedPQ()
        {
            minQueue = new PriorityQueue<int, int>();
            maxQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            entries = new Dictionary<int, int>();
        }
        public bool isEmpty()
        {
            return entries.Count == 0;
        }
        public int? getMin()
        {
            while (minQueue.Count > 0 && !entries.ContainsKey(minQueue.Peek()))
            {
                minQueue.Dequeue();
            }
            return minQueue.Count > 0 ? (int?)minQueue.Peek() : null;
        }

        public int? getMax()
        {
            while (maxQueue.Count > 0 && !entries.ContainsKey(maxQueue.Peek()))
            {
                maxQueue.Dequeue();
            }
            return maxQueue.Count > 0 ? (int?)maxQueue.Peek() : null;
        }

        public void deleteMin()
        {
            if (isEmpty()) return;
            int? value = getMin();
            removeFromEntry(value);
        }
        public void deleteMax()
        {
            if (isEmpty()) return;
            int? value = getMax();
            removeFromEntry(value);
        }

        private void removeFromEntry(int? element)
        {
            if (!element.HasValue)
            {
            }
            else
            {
                int elementI = element.Value;
                if (entries[elementI] > 1)
                {
                    entries[elementI]--;
                }
                else
                {
                    entries.Remove(elementI);
                }
            }
        }
        public void insert(int x)
        {
            if (entries.ContainsKey(x))
            {
                entries[x]++;
            }
            else
            {
                entries.Add(x, 1);
                minQueue.Enqueue(x, x);
                maxQueue.Enqueue(x, x);
            }
        }
    }

    public static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        int testCaseNum = int.Parse(line[0]);
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < testCaseNum; i++)
        {
            DblEndedPQ pq = new DblEndedPQ();
            string[] line2 = Console.ReadLine().Split(' ');
            int operationNum = int.Parse(line2[0]);
            for (int j = 0; j < operationNum; j++)
            {
                string[] line3 = Console.ReadLine().Split(' ');
                string operation = line3[0];
                if (operation == "I")
                {
                    int x = int.Parse(line3[1]);
                    pq.insert(x);
                }
                else if (operation == "D")
                {
                    int x = int.Parse(line3[1]);
                    if (x == 1)
                    {
                        pq.deleteMax();
                    }
                    else if (x == -1)
                    {
                        pq.deleteMin();
                    }
                }
            }

            int? max = pq.getMax();
            int? min = pq.getMin();

            if (max.HasValue && min.HasValue)
            {
                sb.Append(max.Value + " " + min.Value + "\n");
            }
            else
            {
                sb.Append("EMPTY\n");
            }
        }
        System.Console.WriteLine(sb);
    }
}