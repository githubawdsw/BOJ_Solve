// BOJ_2961


int n = int.Parse(Console.ReadLine());
List<(long, long)> list = new List<(long, long)>();
bool[] used = new bool[15];
for (int i = 0; i < n; i++)
{
    int[] inputFlavor = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    long sour = inputFlavor[0];
    long bitter = inputFlavor[1];
    list.Add((sour, bitter));
}

long ans = int.MaxValue;
Dfs(0,1,0);

Console.WriteLine(ans);

void Dfs(int depth, long mul, long sum)
{
    if(depth == n)
        return;

    for (int i = 0; i < n; i++)
    {
        if (used[i])
            continue;

        var cur = list[i];
        used[i] = true;
        ans = Math.Min(ans, Math.Abs((mul * cur.Item1) - (sum + cur.Item2)));
        Dfs(depth + 1, mul * cur.Item1, sum + cur.Item2);
        used[i] = false;
    }
}