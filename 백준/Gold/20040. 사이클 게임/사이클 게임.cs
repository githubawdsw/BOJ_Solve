// BOJ_20040


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] par = new int[500005];
int ans = int.MaxValue;
for (int i = 0; i <= n; i++)
{
    par[i] = -1;
}

for (int i = 1; i <= m; i++)
{
    int[] inputLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int p1 = inputLine[0];
    int p2 = inputLine[1];

    if (Is_Diff_Group(p1, p2))
        continue;
    else
        ans = Math.Min(ans, i);
}

if (ans == int.MaxValue)
    ans = 0;
Console.WriteLine(ans);


bool Is_Diff_Group(int a ,int b)
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
    if (par[x] < 0)
        return x;
    return par[x] = Find(par[x]);
}