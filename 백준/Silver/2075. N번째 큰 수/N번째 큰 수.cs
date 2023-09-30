using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue_
{
    
    class BOJ_2075
    {
        public class Priority_Queue // 최소힙
        {
            static int[] heap = new int[3000005];
            int size = 0;
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
                    if (right <= size && heap[left] < heap[right])
                        bigger = right;
                    if (heap[bigger] < heap[idx])
                        break;
                    int swap = heap[bigger];
                    heap[bigger] = heap[idx];
                    heap[idx] = swap;
                    idx = bigger;
                }
            }
        }
        static void Main(string[] args)
        {
            Priority_Queue pq = new Priority_Queue();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputarr = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    pq.Add(int.Parse(inputarr[j]));
            }
            for (int i = 0; i < n-1; i++)
                pq.Pop();
            Console.WriteLine(pq.Top());
        }
    }
    
}
