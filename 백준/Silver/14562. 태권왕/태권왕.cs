// BOJ_14562

using System.Text;

StringBuilder sb = new StringBuilder();

int c = int.Parse(Console.ReadLine());
while (c-- > 0)
{
    string[] inputst = Console.ReadLine().Split(' ');
    int s = int.Parse(inputst[0]);
    int t = int.Parse(inputst[1]);

    Queue<(int, int, int)> q = new Queue<(int, int, int)>();
    q.Enqueue((s, t, 0));
    while (q.Count > 0)
    {
        var cur = q.Dequeue();

        if (cur.Item1 == cur.Item2)
        {
            sb.AppendLine(cur.Item3.ToString());
            break;
        }
        else if (cur.Item1 > cur.Item2)
            continue;

        q.Enqueue((cur.Item1 + 1, cur.Item2, cur.Item3 + 1));

        q.Enqueue((cur.Item1 * 2, cur.Item2 + 3, cur.Item3 + 1));
    }
}

Console.WriteLine(sb);
