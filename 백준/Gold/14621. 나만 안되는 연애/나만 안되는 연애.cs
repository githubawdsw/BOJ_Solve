// BOJ_14621


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

string[] gender = Console.ReadLine().Split(' ');
List<(int, int, int)> list = new List<(int, int, int)>();
int[] par = new int[1005];
for (int i = 0; i < m; i++)
{
    int[] inputuvd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int u = inputuvd[0];
    int v = inputuvd[1];
    int d = inputuvd[2];
    list.Add((d, u, v));
}

list = list.OrderBy(x => x.Item1).ToList();

int count = 0;
int ans = 0;
for (int i = 0; i < m; i++)
{
    var cur = list[i];
    if (gender[cur.Item2 - 1] == gender[cur.Item3 - 1] || !IsDiffGroup(cur.Item2, cur.Item3))
        continue;
    ans += cur.Item1;
    count++;
    if (count == n - 1)
        break;
}

for (int i = 1; i <= n; i++)
{
    if (par[i] == 0)
    {
        ans = -1;
        break;
    }
}
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