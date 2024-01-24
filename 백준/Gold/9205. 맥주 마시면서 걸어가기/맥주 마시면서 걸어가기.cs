// BOJ_9205



using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    List<(int, int)> list = new List<(int, int)>();
    Queue<int> q = new Queue<int>();
    List<int>[] route = new List<int>[105];
    bool[] vis = new bool[105];

    int n = int.Parse(Console.ReadLine());
    int[] inputHome = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    route[0] = new List<int>();
    for (int i = 0; i < n; i++)
    {
        int[] convenienceStore= Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        list.Add((convenienceStore[0], convenienceStore[1]));
        if (Math.Abs(inputHome[0] - convenienceStore[0]) + Math.Abs(inputHome[1] - convenienceStore[1]) <= 1000)
            route[0].Add(i + 1);
    }

    int[] inputDestination = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (Math.Abs(inputHome[0] - inputDestination[0]) + Math.Abs(inputHome[1] - inputDestination[1]) <= 1000)
        route[0].Add(n + 1);
    for (int i = 1; i <= n; i++)
    {
        route[i] = new List<int>();
        for (int j = 0; j < n; j++)
        {
            if (i - 1 == j)
                continue;
            if (Math.Abs(list[i - 1].Item1 - list[j].Item1) + Math.Abs(list[i - 1].Item2 - list[j].Item2) <= 1000)
                route[i].Add(j + 1);
        }
        if (Math.Abs(list[i - 1].Item1 - inputDestination[0]) + Math.Abs(list[i - 1].Item2 - inputDestination[1]) <= 1000)
            route[i].Add(n + 1);
    }

    bool check = false;
    q.Enqueue(0);
    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        foreach (var one in route[cur])
        {
            if (one == n + 1)
                check = true;
            if (vis[one])
                continue;

            vis[one] = true;
            q.Enqueue(one);
        }
        if (check)
            break;
    }
    if (check)
        sb.AppendLine("happy");
    else
        sb.AppendLine("sad");
}

Console.WriteLine(sb);
