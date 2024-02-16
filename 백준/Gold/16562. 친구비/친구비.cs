// BOJ_16562


int[] inputnmk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmk[0];
int m = inputnmk[1];
int k = inputnmk[2];

int[] costArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] parent = new int[10005];
bool[] vis = new bool[10005];
int ans = 0;
/*
for (int i = 0; i < n; i++)
    parent[i] = -1;
*/
for (int i = 0; i < m; i++)
{
    int[] relInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int v = relInfo[0];
    int w = relInfo[1];

    is_diff_group(v, w);
}

for (int i = 0; i < n; i++)
{
    int root = find(i + 1);
    if (vis[root])
        continue;

    vis[root] = true;
    ans += costArr[root - 1];
    if (ans > k)
    {
        Console.WriteLine("Oh no");
        return;
    }
}

Console.WriteLine(ans);



void is_diff_group(int a, int b)
{
    a = find(a); b = find(b);
    if (a == b)
        return;
    if (parent[a] == parent[b])
        parent[a]--;

    if (costArr[a - 1] >= costArr[b - 1])
        parent[a] = b;
    else
        parent[b] = a;

    return;
}

int find(int x)
{
    if (parent[x] <= 0)
        return x;

    return parent[x] = find(parent[x]);
}