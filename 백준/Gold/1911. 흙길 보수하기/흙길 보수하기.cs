// BOJ_1911


int[] inputnl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnl[0];
int l = inputnl[1];

List<(int, int)> list = new List<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int s = inputInfo[0];
    int e = inputInfo[1];
    list.Add((s, e));
}

list.Sort();

int cur = 0;
int ans = 0;
for (int i = 0; i < n; i++)
{
    if (list[i].Item1 <= cur && list[i].Item2 > cur)
    {
        int count = (list[i].Item2 - cur) / l;
        int remain = (list[i].Item2 - cur) % l;

        ans += count;
        cur += count * l;
        if (remain != 0)
        {
            ans++;
            cur += l;
        }
    }
    else if( cur < list[i].Item1)
    {
        cur = list[i].Item1;
        i--;
    }
}

Console.WriteLine(ans);