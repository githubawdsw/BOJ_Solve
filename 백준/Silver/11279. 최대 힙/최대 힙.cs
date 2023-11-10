using System;
using System.Text;

namespace PriorityQueue_
{

    class BOJ_11279
    {
        public class Priority_Queue // 최대힙
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
                    if (heap[idx] <= heap[par])
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
                    if (heap[idx] >= heap[bigger])
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
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                n--;
                int inputVal = int.Parse(Console.ReadLine());
                if (inputVal != 0)
                    pq.Add(inputVal);
                else
                {
                    if (pq.SIZE == 0)
                        sb.AppendLine("0");
                    else
                    {
                        sb.AppendLine(pq.Top().ToString());
                        pq.Pop();
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
    
}
