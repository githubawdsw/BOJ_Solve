// BOJ_1347


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
string move = Console.ReadLine();

bool[,] board = new bool[120, 120];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
int dir = 0;
(int, int) cur = (60, 60);
board[60, 60] = true;

int minx = 60; int maxx = 60;
int miny = 60; int maxy = 60;

for (int i = 0; i < move.Length; i++)
{
    if (move[i] == 'L')
    {
        dir++;
        if (dir > 3)
            dir = 0;
    }
    else if (move[i] == 'R')
    {
        dir--;
        if (dir < 0)
            dir = 3;
    }
    else
    {
        int nx = cur.Item1 + dx[dir];
        int ny = cur.Item2 + dy[dir];
        board[nx, ny] = true;
        cur = (nx, ny);

        minx = Math.Min(minx, nx);
        maxx = Math.Max(maxx, nx);
        miny = Math.Min(miny, ny);
        maxy = Math.Max(maxy, ny);
    }
}

for (int i = minx; i <= maxx; i++)
{
    for (int j = miny; j <= maxy; j++)
    {
        if (board[i, j])
            sb.Append('.');
        else
            sb.Append('#');
    }
    sb.AppendLine();
}

Console.WriteLine(sb);