using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BinarySearchTree
{
    
    class Priority_Queue
    {
        static int[] heap = new int[100000005];
        static int size = 0;

        public int SIZE
        {
            get { return size; }
            set { size = value; }
        }
        public void Add(int x)
        {
            heap[++size] = x;
            int idx = size;
            while (idx != 1)
            {
                int par = idx / 2;
                if (heap[par] >= heap[idx])
                    break;
                int swap = heap[par];
                heap[par] = heap[idx];
                heap[idx] = swap;
                idx = par;
            }
        }

        public int Top()
        {
            return heap[1];
        }

        public void Pop()
        {
            heap[1] = heap[size--];
            heap[size + 1] = 0;
            int idx = 1;
            while (idx * 2 <= size)
            {
                int left = idx * 2; int right = idx * 2 + 1;
                int bigger = left;
                if (right<= size && heap[left] < heap[right])
                    bigger = right;
                if (heap[bigger] <= heap[idx])
                    break;
                int swap = heap[bigger];
                heap[bigger] = heap[idx];
                heap[idx] = swap;
                idx = bigger;
            }
        }
    }

    class BOJ_1202
    {
        static void Main(string[] args)
        {
            string[] inputnk = Console.ReadLine().Split(' ');
            int n = int.Parse(inputnk[0]);
            int k = int.Parse(inputnk[1]);
            Dictionary<int, List<int>> jewel = new Dictionary<int, List<int>>();
            List<int> backPack = new List<int>();
            Priority_Queue pq = new Priority_Queue();

            for (int i = 0; i < n; i++)
            {
                string[] inputMV = Console.ReadLine().Split(' ');
                if (!jewel.ContainsKey(int.Parse(inputMV[0])))
                    jewel[int.Parse(inputMV[0])] = new List<int>();
                jewel[int.Parse(inputMV[0])].Add(int.Parse(inputMV[1]));
            }
            jewel = jewel.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            for (int i = 0; i < k; i++)
                backPack.Add(int.Parse(Console.ReadLine()));
            backPack.Sort();

            int m = 0;
            List<int> keys = new List<int>(jewel.Keys);
            long ans = 0;
            for (int i = 0; i < k; i++)
            {
                while (m < keys.Count &&keys[m] <= backPack[i])
                {
                    foreach (var one in jewel[keys[m]])
                        pq.Add(one);
                    m++;
                }
                if(pq.SIZE != 0)
                {
                    ans += pq.Top();
                    pq.Pop();
                }
            }
            Console.WriteLine(ans);
        }
    }
    
}
