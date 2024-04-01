// BOJ_1865


using System.Text;

StringBuilder sb = new StringBuilder();
int tc = int.Parse(Console.ReadLine());
while (tc-- != 0)
{
    int[] inputnmw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = inputnmw[0];
    int m = inputnmw[1];
    int w = inputnmw[2];

    List<(int, int, int)> list = new List<(int, int, int)>();
    for (int i = 0; i < m; i++)
    {
        int[] inputset = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int s = inputset[0];
        int e = inputset[1];
        int t = inputset[2];

        list.Add((s, e, t));
        list.Add((e, s, t));

    }
    for (int i = 0; i < w; i++)
    {
        int[] inputset = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int s = inputset[0];
        int e = inputset[1];
        int t = inputset[2];

        list.Add((s, e, -t)); 
    }

    if (Solve(n, list))
        sb.AppendLine("YES");
    else
        sb.AppendLine("NO");
}

Console.WriteLine(sb);


bool Solve(int n , List<(int, int, int)> list)
{
    int[] dis = new int[505];
    dis[1] = 0;

    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < list.Count; j++)
        {
            if (dis[list[j].Item2] > dis[list[j].Item1] + list[j].Item3)
                dis[list[j].Item2] = dis[list[j].Item1] + list[j].Item3;
        }
    }

    for (int i = 0; i < list.Count; i++)
    {
        if (dis[list[i].Item2] > dis[list[i].Item1] + list[i].Item3)
            return true;
    }
    return false;
}