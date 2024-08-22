// BOJ_23757



int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] inputPresent = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] inputKidNum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

PriorityQueueMax pq = new PriorityQueueMax();
for (int i = 0; i < n; i++)
{
    pq.Add(inputPresent[i]);
}

for (int i = 0; i < m; i++)
{
    var cur = pq.Top();
    pq.Pop();

    if(pq.SIZE == 0)
    {
        Console.WriteLine(0);
        return;
    }

    if (inputKidNum[i] < cur)
        pq.Add(cur - inputKidNum[i]);
    else if (inputKidNum[i] > cur)
    {
        Console.WriteLine(0);
        return;
    }
}

Console.WriteLine(1);


public class PriorityQueueMax
{
    int[] heap = new int[100005];
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
            int bigger = left;
            if (right <= size && heap[left] < heap[right])
                bigger = right;

            if (heap[idx] >= heap[bigger])
                break;

            (heap[bigger], heap[idx]) = (heap[idx], heap[bigger]);
            idx = bigger;
        }
    }

    public int Top()
    {
        return heap[1];
    }
}