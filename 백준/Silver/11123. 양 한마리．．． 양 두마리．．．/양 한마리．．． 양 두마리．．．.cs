// BOJ_11123


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

while (t-- > 0)
{
    int[] inputhw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int h = inputhw[0];
    int w = inputhw[1];

    char[,] board = new char[105, 105];
    bool[,] vis = new bool[105, 105];
    Queue<(int, int)> q = new Queue<(int, int)>();
    for (int i = 0; i < h; i++)
    {
        string inputInfo = Console.ReadLine();
        for (int j = 0; j < w; j++)
        {
            board[i, j] = inputInfo[j];
        }
    }

    int count = 0;
    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < w; j++)
        {
            if (vis[i, j])
                continue;

            if (board[i,j] == '#')
            {
                q.Enqueue((i, j));
                while (q.Count > 0)
                {
                    var cur = q.Dequeue();
                    vis[cur.Item1, cur.Item2] = true;

                    for (int k = 0; k < 4; k++)
                    {
                        int nx = cur.Item1 + dx[k];
                        int ny = cur.Item2 + dy[k];

                        if (nx < 0 || ny < 0 || nx >= h || ny >= w)
                            continue;
                        if (vis[nx, ny] || board[nx,ny] == '.')
                            continue;

                        vis[nx, ny] = true;
                        q.Enqueue((nx, ny));
                    }
                }
                count++;
            }
        }
    }
    sb.AppendLine(count.ToString());
}

Console.WriteLine(sb);