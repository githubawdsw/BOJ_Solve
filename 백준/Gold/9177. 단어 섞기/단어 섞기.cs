// BOJ_9177


using System.Text;

StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());
for (int i = 1; i <= t; i++)
{
    string[] words = Console.ReadLine().Split(' ');
    string first = words[0];
    string second = words[1];
    string target = words[2];

    bool check = false;
    bool[,] vis = new bool[205, 205];
    Queue<(int,int,int)> q = new Queue<(int,int,int)>();
    q.Enqueue((first.Length, second.Length, target.Length));

    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        if (cur.Item1 == 0 && cur.Item2 == 0 && cur.Item3 == 0)
        {
            check = true;
            break;
        }
        else if (cur.Item3 == 0)
        {
            check = false;
            break;
        }

        if(cur.Item1 > 0 && first[cur.Item1 - 1] == target[cur.Item3 - 1] && !vis[cur.Item1 - 1, cur.Item2])
        {
            vis[cur.Item1 - 1, cur.Item2] = true;
            q.Enqueue((cur.Item1 - 1, cur.Item2, cur.Item3 - 1));
        }
        if (cur.Item2 > 0 && second[cur.Item2 - 1] == target[cur.Item3 - 1] && !vis[cur.Item1, cur.Item2 - 1])
        {
            vis[cur.Item1, cur.Item2 - 1] = true;
            q.Enqueue((cur.Item1, cur.Item2 - 1, cur.Item3 - 1));
        }
    }

    if (q.Count > 0)
        check = false;

    if (check)
        sb.AppendLine($"Data set {i}: yes");
    else
        sb.AppendLine($"Data set {i}: no");
}

Console.WriteLine(sb);