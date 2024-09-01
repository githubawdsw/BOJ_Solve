// BOJ_14698


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    long[] inputEnergy = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

    PriorityMin pq = new PriorityMin();

    for (int i = 0; i < n; i++)
    {
        pq.Add(inputEnergy[i]);
    }

    long ans = 1;
    while (pq.SIZE > 1)
    {
        var cur1 = pq.Top();
        pq.Pop();
        var cur2 = pq.Top();
        pq.Pop();

        ans = (ans * (cur1 * cur2 % 1000000007)) % 1000000007;
        pq.Add(cur1 * cur2);
    }

    sb.AppendLine(ans.ToString());
}


Console.WriteLine(sb);



class PriorityMin
{
    long[] heap = new long[70];
    int size = 0;

    public int SIZE
    {
        get { return size; }
        set { size = value; }
    }

    public void Add(long x)
    {
        heap[++size] = x;
        int idx = size;
        while (idx != 1)
        {
            int par = idx / 2;
            if (heap[par] <= heap[idx])
                break;

            (heap[par], heap[idx]) = (heap[idx], heap[par]);
            idx = par;
        }
    }

    public void Pop()
    {
        heap[1] = heap[size--];
        heap[size + 1] = 0;
        int idx = 1;
        while (idx * 2 <= size)
        {
            int left = idx * 2;
            int right = idx * 2 + 1;
            int min = left;

            if (right <= size && heap[right] < heap[left])
                min = right;
            if (heap[idx] <= heap[min])
                break;

            (heap[idx], heap[min]) = (heap[min], heap[idx]);
            idx = min;
        }
    }

    public long Top()
    {
        return heap[1];
    }
}