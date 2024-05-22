// BOJ_15922


int n = int.Parse(Console.ReadLine());

List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];
    list.Add((x, y));
}

int start = list[0].Item1;
int end = list[0].Item2;
int ans = 0;
for (int i = 1; i < n; i++)
{
    var cur = list[i];
    if (end >= cur.Item1)
        end = Math.Max(end, cur.Item2);
    else
    {
        ans += end - start;
        start = cur.Item1;
        end = cur.Item2;
    }
}

ans += end - start;
Console.WriteLine(ans);