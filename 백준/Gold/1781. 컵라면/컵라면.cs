using System;
using System.Collections.Generic;
using System.Linq;
namespace PriorityQueue_
{
    
    class BOJ_1781
    {
        public class Priority_Queue 
        {
            long[] heap = new long[200005];
            int size = 0;
            bool check = false;
            public int SIZE
            {
                get { return size; }
                set { size = value; }
            }
            public bool Check
            {
                get { return check; }
                set { check = value; }
            }
            public void Add(long x)
            {
                heap[0] = -100001;
                heap[++size] = x;
                int idx = size;
                while (idx != 1)
                {
                    int par = idx / 2;
                    if (heap[par] <= heap[idx] && !check)
                        break;
                    else if (heap[par] >= heap[idx] && check)
                        break;
                    long swap = heap[par];
                    heap[par] = heap[idx];
                    heap[idx] = swap;
                    idx = par;
                }
            }
            public long Top()
            {
                return heap[1];
            }
            public void Pop()
            {
                heap[1] = heap[size--];
                int idx = 1;
                while (idx * 2 <= size)
                {
                    int left = idx * 2; int right = idx * 2 + 1;
                    int comp = left;

                    if (right <= size && heap[left] > heap[right] && !check)
                        comp = right;
                    else if (right <= size && heap[left] < heap[right] && check)
                        comp = right;
                    if (heap[idx] <= heap[comp] && !check)
                        break;
                    else if (heap[idx] >= heap[comp] && check)
                        break;

                    long swap = heap[comp];
                    heap[comp] = heap[idx];
                    heap[idx] = swap;
                    idx = comp;
                }
            }
        }

        static void Main(string[] args)
        {
            Priority_Queue pqMax = new Priority_Queue();
            pqMax.Check = true;
            Dictionary<string, List<long>> maxCup = new Dictionary<string, List<long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 200001; i++)
                maxCup.Add(i.ToString(), new List<long>());
            
            for (int i = 0; i < n; i++)
            {
                string[] inputDC = Console.ReadLine().Split(' ');
                maxCup[inputDC[0]].Add(int.Parse(inputDC[1]));
            }

            long ans = 0;
            for (int j = 200000; j != 0; j--)
            {
                for (int i = 0; i < maxCup[ j.ToString()].Count; i++)
                    pqMax.Add(maxCup[j.ToString()][i]);
                if (pqMax.SIZE == 0)
                    continue;
                ans += pqMax.Top();
                pqMax.Pop();
            }
            
            Console.WriteLine(ans);
        }
    }
    
}
