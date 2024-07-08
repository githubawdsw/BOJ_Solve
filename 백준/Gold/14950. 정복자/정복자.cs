// BOJ_14950


int[] inputnmt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmt[0];
int m = inputnmt[1];
int t = inputnmt[2];

int[] par = new int[10005];
List<(int, int, int)> list = new List<(int, int, int)>();

for (int i = 0; i < m; i++)
{
    int[] inputabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputabc[0];
    int b = inputabc[1];
    int c = inputabc[2];

    list.Add((a, b, c));
}

list = list.OrderBy(x => x.Item3).ToList();

int ans = 0;
int count = 0;
for (int i = 0; i < m; i++)
{
    var cur = list[i];
    if (!IsDiffGroup(cur.Item1, cur.Item2))
        continue;
    ans += cur.Item3;
    count++;
    if (count == n - 1)
        break;
}

ans += (n - 2) * (n - 1) * t / 2;
Console.WriteLine(ans);

bool IsDiffGroup(int a, int b)
{
    a = Find(a); b = Find(b);
    if (a == b)
        return false;
    if (par[a] == par[b])
        par[a]--;
    if (par[a] < par[b])
        par[b] = a;
    else
        par[a] = b;
    return true;
}

int Find(int x)
{
    if (par[x] <= 0)
        return x;
    return par[x] = Find(par[x]);
}