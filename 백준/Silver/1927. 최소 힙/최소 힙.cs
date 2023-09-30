using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue_
{
    
    class BOJ_1927
    {
        public class Priority_Queue // 최소힙
        {
            static int[] heap = new int[100005];
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
                    if (heap[par] <= heap[idx])
                        break;
                    int swap = heap[par];
                    heap[par] = heap[idx];
                    heap[idx] = swap;
                    idx = par;
                }
            }
            public int top()
            {
                return heap[1];
            }
            public void pop()
            {
                heap[1] = heap[size--];
                heap[size + 1] = 0;
                int idx = 1;
                while (2 * idx <= size)
                {
                    int left = 2 * idx; int right = 2 * idx + 1;
                    int min = left;
                    if (right <= size && heap[ left] >heap[ right])
                        min = right;
                    if (heap[idx] <= heap[min])
                        break;
                    int swap = heap[idx];
                    heap[idx] = heap[min];
                    heap[min] = swap;
                    idx = min;
                }
            }
        }
        static void Main(string[] args)
        {
            Priority_Queue pq = new Priority_Queue();
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int inputX = int.Parse(Console.ReadLine());
                if (inputX != 0)
                    pq.Add(inputX);
                else
                {
                    if (pq.SIZE == 0)
                        sb.AppendLine("0");
                    else
                    {
                        sb.AppendLine(pq.top().ToString());
                        pq.pop();
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
    
}
