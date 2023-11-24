using System;
using System.Text;

namespace PriorityQueue_
{
    
    class BOJ_1655
    {
        public class Priority_Queue 
        {
            int[] heap = new int[100005];
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
            public void Add(int x)
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

                    int swap = heap[comp];
                    heap[comp] = heap[idx];
                    heap[idx] = swap;
                    idx = comp;
                }
            }
            public void print()
            {
                for (int i = 1; i <= size; i++)
                {
                    Console.WriteLine(heap[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Priority_Queue pqMin = new Priority_Queue();
            Priority_Queue pqMax = new Priority_Queue();
            pqMax.Check = true;
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                n--;
                int input = int.Parse(Console.ReadLine());
                if (pqMax.SIZE <= pqMin.SIZE)
                    pqMax.Add(input);
                else
                    pqMin.Add(input);
                
                if(pqMin.SIZE != 0 && pqMin.Top() < pqMax.Top())
                {
                    pqMin.Add(pqMax.Top());
                    pqMax.Pop();
                    pqMax.Add(pqMin.Top());
                    pqMin.Pop();
                }
                sb.AppendLine(pqMax.Top().ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
