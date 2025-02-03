// BOJ_11067


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
    int maxx = 0;
    for (int i = 0; i < n; i++)
    {
        int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = inputxy[0];
        int y = inputxy[1];

        if(!dict.ContainsKey(x))
            dict.Add(x, new List<int>());
        dict[x].Add(100000 + y);
        maxx = Math.Max(maxx, x);
    }

    int[] inputCafeNubmer = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    List<(int,int)> cafe = new List<(int,int)>();
    Queue<(int, int)> q = new Queue<(int, int)>();

    q.Enqueue((0, 100000));
    if (dict[0].Count == 1)
        cafe.Add((0, 100000));

    while (cafe.Count < n)
    {
        var cur = q.Dequeue();
        (int, int) target = (0, 0);
        if (dict[cur.Item1].Count > 1)
        {
            dict[cur.Item1].Sort();
            if (cur.Item2 != dict[cur.Item1][0])
                dict[cur.Item1].Reverse();

            for (int i = 0; i < dict[cur.Item1].Count; i++)
            {
                cafe.Add((cur.Item1, dict[cur.Item1][i]));
                target = ((cur.Item1, dict[cur.Item1][i]));
            }
        }

        for (int i = cur.Item1 + 1; i <= maxx; i++)
        {
            if (!dict.ContainsKey(i))
                continue;

            if (target != (0, 0))
                target = (i, target.Item2);
            else
                target = (i, cur.Item2);

            if (dict[i].Count == 1)
                cafe.Add(target);
            break;
        }

        q.Enqueue(target);
    }

    for (int i = 1; i < inputCafeNubmer.Length; i++)
    {
        sb.AppendLine(cafe[inputCafeNubmer[i] - 1].Item1 + " " + (cafe[inputCafeNubmer[i] - 1].Item2 - 100000));
    }
}

Console.WriteLine(sb);