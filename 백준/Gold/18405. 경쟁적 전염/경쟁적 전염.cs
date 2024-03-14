// BOJ_18405


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[,] board = new int[205, 205];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
SortedSet<(int, int, int)> ss = new SortedSet<(int, int, int)>();
Queue<(int, int)> q = new Queue<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < n; j++)
	{
        board[i, j] = inputInfo[j];
        if (board[i, j] != 0)
            ss.Add((inputInfo[j], i, j));
	}
}

foreach (var one in ss)
{
    q.Enqueue((one.Item2, one.Item3));
}

int[] inputsxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int s = inputsxy[0];
int x = inputsxy[1] - 1;
int y = inputsxy[2] - 1;
Queue<(int, int)> temp = new Queue<(int, int)>();

while (s-- > 0)
{
    temp.Clear();
    while (q.Count > 0)
    {
        var cur = q.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int nx = cur.Item1 + dx[i];
            int ny = cur.Item2 + dy[i];

            if (nx < 0 || ny < 0 || nx >= n || ny >= n)
                continue;
            if (board[nx, ny] > 0)
                continue;

            board[nx, ny] = board[cur.Item1, cur.Item2];
            temp.Enqueue((nx, ny));
        }
    }
    q = new Queue<(int,int)>(temp);
}

Console.WriteLine(board[x,y]);