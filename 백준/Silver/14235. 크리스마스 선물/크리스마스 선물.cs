// BOJ_14235


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
for (int i = 0; i < n; i++)
{
    string[] a = Console.ReadLine().Trim().Split(' ');
    int type = int.Parse(a[0]);
    if (type != 0)
    {
        for (int j = 1; j < a.Length; j++)
        {
            var cur = int.Parse(a[j]);
            pq.Enqueue(cur * -1, cur * -1);
        }
    }
    else
    {
        if (pq.Count > 0)
            sb.AppendLine((pq.Dequeue() * -1).ToString());
        else
            sb.AppendLine("-1");
    }
}

Console.WriteLine(sb);