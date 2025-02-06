// BOJ_14712


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int ans = 0;
bool[,] vis = new bool[n, m];
Dfs(0, 0);

Console.WriteLine(ans);


void Dfs(int depth, int idx)
{
    ans += Check() ? 1 : 0;
    if(depth == n * m)
    {
        return;
    }

    for (int i = idx; i < n * m; i++)
    {
        int r = i / m;
        int c = i % m;

        vis[r, c] = true;
        Dfs(depth + 1, i + 1);
        vis[r, c] = false;
    }
}

bool Check()
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < m - 1; j++)
        {
            if (vis[i, j] && vis[i + 1, j] && vis[i, j + 1] && vis[i + 1, j + 1])
                return false;
        }
    }
    return true;
}