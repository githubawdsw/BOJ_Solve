// BOJ_13265


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = inputnm[0];
    int m = inputnm[1];

    int[] colorCheck = new int[1005];
    List<int>[] list = new List<int>[n + 3];
    for (int i = 0; i < m; i++)
    {
        int[] inputPos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int p1 = inputPos[0];
        int p2 = inputPos[1];

        if (list[p1] == null)
            list[p1] = new List<int>();
        list[p1].Add(p2);

        if (list[p2] == null)
            list[p2] = new List<int>();
        list[p2].Add(p1);
    }

    bool possibleCheck = true;
    for (int i = 1; i <= n; i++)
    {
        if (colorCheck[i] == 0)
        {
            if (!Bfs(i, colorCheck, list))
            {
                possibleCheck = false;
                break;
            }
        }
    }
    if (possibleCheck)
        sb.AppendLine("possible");
    else
        sb.AppendLine("impossible");
}

Console.WriteLine(sb);


bool Bfs(int start, int[] colorCheck, List<int>[] list)
{
    colorCheck[start] = 1;
    Queue<int> q = new Queue<int>();
    q.Enqueue(start);
    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        if (list[cur] == null)
            continue;
        foreach (var one in list[cur])
        {
            if (colorCheck[one] == 0)
            {
                colorCheck[one] = colorCheck[cur] == 1 ? 2 : 1;
                q.Enqueue(one);
            }
            else
            {
                if (colorCheck[one] == colorCheck[cur])
                    return false;
            }
        }
    }
    return true;
}
