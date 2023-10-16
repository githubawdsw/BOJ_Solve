using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue_
{

    class BOJ_11286
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
                heap[++size ] = x;
                int idx = size;
                while (idx != 1)
                {
                    int par = idx / 2;
                    if (Math.Abs( heap[par]) <=Math.Abs(heap[idx]))
                    {
                        while (par != 0)
                        {
                            if(heap[par] > heap[idx] && Math.Abs(heap[par]) == Math.Abs(heap[idx]))
                            {
                                int swap = heap[par];
                                heap[par] = heap[idx];
                                heap[idx] = swap;
                            }
                            idx = par;
                            par /= 2;
                        }
                        break;
                    }
                    int temp = heap[par];
                    heap[par] = heap[idx];
                    heap[idx] = temp;
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
                    int left = idx * 2; int right = idx * 2 + 1;
                    int min = left;
                    if (right <= size &&Math.Abs( heap[right]) <Math.Abs( heap[left]))
                        min = right;
                    if (right <= size && Math.Abs(heap[right]) == Math.Abs(heap[left]) && heap[left] > heap[right])
                        min = right;
                    if (Math.Abs( heap[idx]) <= Math.Abs(heap[min]))
                    {
                        if (heap[idx] > heap[min] && Math.Abs(heap[idx]) == Math.Abs(heap[min]))
                        {
                            int swap = heap[idx];
                            heap[idx] = heap[min];
                            heap[min] = swap;
                        }
                        break;
                    }
                    int temp = heap[idx];
                    heap[idx] = heap[min];
                    heap[min] = temp;
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
