// BOJ_10282


using System.Text;

StringBuilder sb= new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    string[] inputndc = Console.ReadLine().Split(' ');
    int n = int.Parse(inputndc[0]);
    int d = int.Parse(inputndc[1]);
    int c = int.Parse(inputndc[2]);

    List<Tuple<int, int>>[] tupleList = new List<Tuple<int, int>>[10005];
    for (int i = 0; i < d; i++)
    {
        string[] inputabs = Console.ReadLine().Split(' ');
        int a = int.Parse(inputabs[0]);
        int b = int.Parse(inputabs[1]);
        int s = int.Parse(inputabs[2]);
        if (tupleList[b] == null)
            tupleList[b] = new List<Tuple<int, int>>();
        tupleList[b].Add(new Tuple<int, int>(s, a));
    }

    int[] dp = new int[10005];
    Array.Fill(dp, int.MaxValue / 2);
    dp[c] = 0;

    PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
    pq.Enqueue(new Tuple<int, int>(0, c), 0);
    while (pq.Count > 0)
    {
        var cur = pq.Dequeue();
        if (dp[cur.Item2] != cur.Item1)
            continue;
        if (tupleList[cur.Item2] == null)
            continue;
        foreach (var one in tupleList[cur.Item2])
        {
            if (dp[one.Item2] > dp[cur.Item2] + one.Item1)
            {
                dp[one.Item2] = dp[cur.Item2] + one.Item1;
                pq.Enqueue(new Tuple<int, int>(dp[one.Item2], one.Item2), one.Item2);
            }
        }
    }

    int time = 0;
    int count = 0;
    for (int i = 1; i <= n; i++)
    {
        if (dp[i] != int.MaxValue / 2)
        {
            count++;
            time = Math.Max(dp[i], time);
        }
    }
    sb.AppendLine($"{count} {time}");
}

Console.WriteLine(  sb);
