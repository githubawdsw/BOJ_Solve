// BOJ_4963



using System.Text;

StringBuilder sb = new StringBuilder();
int[] dx = { 1, 0, -1, 0, 1, -1, 1, -1 };
int[] dy = { 0, 1, 0, -1, 1, -1, -1, 1 };

while (true)
{
    string[] inputwh = Console.ReadLine().Split(' ');
    int w = int.Parse(inputwh[0]);
    int h = int.Parse(inputwh[1]);
    if (w == 0 && h == 0)
        break;

    int[,] board = new int[53, 53];
    bool[,] vis = new bool[53, 53];
    Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();


    int count = 0;
    for (int i = 0; i < h; i++)
    {
        string[] inputmap = Console.ReadLine().Split(" ");
        for (int j = 0; j < w; j++)
            board[i,j] = int.Parse(inputmap[j]);
    }

    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < w; j++)
        {
            if (board[i, j] == 0)
                continue;

            if (!vis[i,j])
            {
                q.Enqueue(new Tuple<int, int>(i, j));
                count++;
            }

            vis[i, j] = true;
            while (q.Count != 0)
            {
                var cur = q.Dequeue();
                for (int k = 0; k < 8; k++)
                {
                    int nx = dx[k] + cur.Item1;
                    int ny = dy[k] + cur.Item2;
                    if (nx < 0 || ny < 0 || nx >= h || ny >= w)
                        continue;
                    if (vis[nx, ny] || board[nx,ny] == 0)
                        continue;
                    vis[nx, ny] = true;
                    q.Enqueue(new Tuple<int, int>(nx, ny));
                }
            }
        }
    }
    sb.AppendLine(count.ToString());
}

Console.WriteLine(  sb );
