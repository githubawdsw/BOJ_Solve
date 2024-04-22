// BOJ_16973


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[1005, 1005];
int[,] dis = new int[1005, 1005];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

for (int i = 0; i < n; i++)
{
    int[] inputBoard = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        board[i, j] = inputBoard[j];
	}
}

int[] inputhwsf = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int h = inputhwsf[0] - 1;
int w = inputhwsf[1] - 1;
int sr = inputhwsf[2] - 1;
int sc = inputhwsf[3] - 1;
int fr = inputhwsf[4] - 1;
int fc = inputhwsf[5] - 1;

Queue<(int, int, int, int)> q = new Queue<(int, int, int, int)>();
q.Enqueue((sr, sc, sr + h, sc + w));

int ans = 0;
dis[sr, sc] = 1;
while (q.Count > 0)
{
    var cur = q.Dequeue();
    if(cur.Item1 == fr & cur.Item2 == fc)
    {
        ans = dis[cur.Item1,cur.Item2];
        break;
    }
    for (int i = 0; i < 4; i++)
    {
        (int, int) vertex1 = (cur.Item1 + dx[i], cur.Item2 + dy[i]);
        (int, int) vertex2 = (cur.Item3 + dx[i], cur.Item4 + dy[i]);
        if (vertex1.Item1 < 0 || vertex1.Item2 < 0 || vertex2.Item1 >= n || vertex2.Item2 >= m)
            continue;
        if (dis[vertex1.Item1, vertex1.Item2] != 0)
            continue;
        if (!CheckInside(vertex1.Item1, vertex1.Item2, vertex2.Item1, vertex2.Item2))
            continue;

        dis[vertex1.Item1, vertex1.Item2] = dis[cur.Item1, cur.Item2] + 1;
        q.Enqueue((vertex1.Item1, vertex1.Item2, vertex2.Item1, vertex2.Item2));
    }
}

Console.WriteLine(ans - 1);


bool CheckInside(int sr, int sc, int er, int ec)
{
    for (int i = sr; i <= er; i++)
    {
        if (board[i, sc] == 1)
            return false;
        if (board[i, ec] == 1)
            return false;
    }
    for (int i = sc; i <= ec; i++)
    {
        if (board[sr, i] == 1)
            return false;
        if (board[er, i] == 1)
            return false;
    }
    
    return true;
}