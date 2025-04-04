// BOJ_24391


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] par = new int[100005];
for (int i = 0; i < n; i++)
{
    par[i] = -1;
}

for (int i = 0; i < m; i++)
{
    int[] inputConnect = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int building1 = inputConnect[0];
    int building2 = inputConnect[1];

    Is_Diff_Group(building1, building2);
}

int[] move = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int cur = move[0];
int ans = 0;
for (int i = 1; i < move.Length; i++)
{
    int target = move[i];
    if (Find(cur) != Find(target))
        ans++;
    cur = target;
}

Console.WriteLine(ans);


bool Is_Diff_Group(int a, int b)
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