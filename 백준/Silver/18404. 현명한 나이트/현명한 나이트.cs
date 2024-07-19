// BOJ_18404


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[505, 505];
int[,] dis = new int[505, 505];
Queue<(int, int)> q = new Queue<(int, int)>();
int[] dx = { 2, 2, 1, 1, -1, -1, -2, -2 };
int[] dy = { 1, -1, 2, -2, 2, -2, 1, -1 };

int[] knightPos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int x = knightPos[0];
int y = knightPos[1];
board[x, y] = 1;
q.Enqueue((x, y));

List<(int, int)> list = new List<(int, int)>();

for (int i = 0; i < m; i++)
{
    int[] inputEnemy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputEnemy[0];
    int b = inputEnemy[1];

    board[a, b] = 2;
    list.Add((a, b));
}

int count = 0;
while (q.Count > 0)
{
    var cur = q.Dequeue();

    for (int i = 0; i < 8; i++)
    {
        int nx = cur.Item1 + dx[i];
        int ny = cur.Item2 + dy[i];

        if (nx <= 0 || ny <= 0 || nx > n || ny > n)
            continue;
        if (dis[nx, ny] > 0 || board[nx,ny] == 1)
            continue;

        dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;
        q.Enqueue((nx, ny));

        if (board[nx, ny] == 2)
            count++;
    }
    if (count == m)
        break;
}

for (int i = 0; i < list.Count; i++)
{
    sb.Append($"{dis[list[i].Item1, list[i].Item2]} ");
}
Console.WriteLine(sb);