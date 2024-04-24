// BOJ_17352


int[] par = new int[300005];
Array.Fill(par, -1);

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n - 2; i++)
{
    int[] inputIsland = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputIsland[0];
    int b = inputIsland[1];

    IsDiffGroup(a, b);
}
for (int i = 2; i <= n; i++)
{
    if(IsDiffGroup(1, i))
    {
        Console.WriteLine("1 " + $"{i}");
        return;
    }
}
bool IsDiffGroup(int x, int y)
{
    x = Find(x); y = Find(y);
    if (x == y)
        return false;

    if (par[x] == par[y])
        par[x]--;

    if (par[x] < par[y])
        par[x] = y;
    else
        par[y] = x;
    return true;
}

int Find(int x)
{
    if (par[x] <= 0)
        return x;
    return par[x] = Find(par[x]);
}