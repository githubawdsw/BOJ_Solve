// BOJ_16197


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int m = inputnk[1];

char[,] board = new char[25, 25];
int[,,,] dis = new int[25, 25, 25, 25];
Queue<(int, int, int, int)> q = new Queue<(int, int, int, int)>();
List<(int, int)> coin = new List<(int, int)>();
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
for (int i = 0; i < n; i++)
{
    string inputInfo = Console.ReadLine();
    for (int j = 0; j < m; j++)
    {
        board[i, j] = inputInfo[j];
        if (inputInfo[j] == 'o')
            coin.Add((i, j));
    }
}

q.Enqueue((coin[0].Item1, coin[0].Item2, coin[1].Item1, coin[1].Item2));
dis[coin[0].Item1, coin[0].Item2, coin[1].Item1, coin[1].Item2] = 1;
bool check = false;
int ans = -1;
while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (dis[cur.Item1, cur.Item2, cur.Item3, cur.Item4] > 10)
        break;
    
    for (int i = 0; i < 4; i++)
    {
        int nx1 = cur.Item1 + dx[i];
        int ny1 = cur.Item2 + dy[i];

        int nx2 = cur.Item3 + dx[i];
        int ny2 = cur.Item4 + dy[i];

        if ((nx1 < 0 && nx2 < 0) || (ny1 < 0 && ny2 < 0) || (nx1 >= n && nx2 >= n) || (ny1 >= m && ny2 >= m))
            continue;

        if (nx1 < 0 || nx2 < 0 || ny1 < 0 || ny2 < 0 || nx1 >= n || nx2 >= n || ny1 >= m || ny2 >= m)
        {
            check = true;
            ans = dis[cur.Item1, cur.Item2, cur.Item3, cur.Item4];
            break;
        }

        if (board[nx1, ny1] == '#')
        {
            nx1 -= dx[i];
            ny1 -= dy[i];
        }

        if (board[nx2, ny2] == '#')
        {
            nx2 -= dx[i];
            ny2 -= dy[i];
        }

        if (dis[nx1,ny1,nx2,ny2] == 0)
        {
            dis[nx1, ny1, nx2, ny2] = dis[cur.Item1, cur.Item2, cur.Item3, cur.Item4] + 1;
            q.Enqueue((nx1, ny1, nx2, ny2));
        }

    }
    if (check)
        break;
}

Console.WriteLine(ans);
