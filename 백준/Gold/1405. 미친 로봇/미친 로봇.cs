// BOJ_1405


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnDir = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnDir[0];
int E = inputnDir[1];
int W = inputnDir[2];
int S = inputnDir[3];
int N = inputnDir[4];

int[] dx = { 0, 0, 1, -1 };
int[] dy = { -1, 1, 0, 0 };
bool[,] vis = new bool[30, 30];
vis[15, 15] = true;

double ans = 0;
Dfs(0, 15, 15, 1);

Console.WriteLine(ans);


void Dfs(int depth, int x, int y, double sum)
{
    if(depth == n)
    {
        ans += sum;
        return;
    }

    for (int i = 0; i < 4; i++)
    {
        int nx = x + dx[i];
        int ny = y + dy[i];

        if (vis[nx, ny])
            continue;

        vis[nx, ny] = true;
        Dfs(depth + 1, nx, ny, sum * inputnDir[i + 1] / 100);
        vis[nx, ny] = false;
    }
}