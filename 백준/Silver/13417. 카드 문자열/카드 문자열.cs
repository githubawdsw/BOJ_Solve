// BOJ_13417



using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    char[] inputCard = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);

    DeQue dq = new DeQue();
    dq.Push(inputCard[0]);
    for (int i = 1; i < n; i++)
    {
        var cur = inputCard[i];
        if (dq.Top() >= cur)
            dq.Push(cur);
        else
            dq.EnQueue(cur);
    }

    for (int i = 0; i < n; i++)
    {
        sb.Append((char)dq.Top());
        dq.Pop();
    }
    sb.AppendLine();
}

Console.WriteLine(sb);



public class DeQue
{
    static char[] heap = new char[1005];
    int size = 0;

    public void Push(char x)
    {
        int idx = size++;

        while (idx > 0)
        {
            heap[idx] = heap[idx - 1];
            idx--;
        }
        heap[0] = x;
    }

    public int SIZE
    {
        get { return size; }
        set { size = value; }
    }

    public int Top()
    {
        return heap[0];
    }

    public void Pop()
    {
        int idx = 0;
        while (idx < size)
        {
            heap[idx] = heap[idx + 1];
            idx++;
        }
        heap[size--] = '\0';
    }

    public void EnQueue(char x)
    {
        int idx = size++;
        heap[idx] = x;
    }
}
