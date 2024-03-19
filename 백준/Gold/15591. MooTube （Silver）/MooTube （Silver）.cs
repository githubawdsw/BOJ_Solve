// BOJ_15591


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputNQ = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = inputNQ[0];
int Q = inputNQ[1];

List<(int, int)>[] list = new List<(int, int)>[5005];
for (int i = 0; i < N - 1; i++)
{
    int[] inputpqr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int p = inputpqr[0];
    int q = inputpqr[1];
    int r = inputpqr[2];

    if (list[p] == null)
        list[p] = new List<(int, int)>();
    list[p].Add((q, r));
    if (list[q] == null)
        list[q] = new List<(int, int)>();
    list[q].Add((p, r));
}

Queue<(int, int)> qTuple = new Queue<(int, int)>();
for (int i = 0; i < Q; i++)
{
    int[] inputkv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int k = inputkv[0];
    int v = inputkv[1];
    bool[] vis = new bool[5005];

    vis[v] = true;
    int ans = 0;
    qTuple.Enqueue((v, k));
    
    while (qTuple.Count > 0)
    {
        var cur = qTuple.Dequeue();

        if (list[cur.Item1] == null)
            continue;

        foreach (var one in list[cur.Item1])
        {
            if (one.Item2 < cur.Item2 || vis[one.Item1])
                continue;

            vis[one.Item1] = true;
            qTuple.Enqueue((one.Item1, cur.Item2));
        }
    }

    for (int j = 0; j <= N; j++)
    {
        if (vis[j])
            ans++;
    }
    sb.AppendLine((ans - 1).ToString());
}

Console.WriteLine(sb);