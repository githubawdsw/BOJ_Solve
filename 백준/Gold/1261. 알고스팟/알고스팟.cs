// BOJ_1261

int[,] board = new int[105, 105];
int[][] dp = new int[105][];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };

string[] inputnm = Console.ReadLine().Split(' ');
int m = int.Parse(inputnm[0]);
int n = int.Parse(inputnm[1]); 
for (int i = 0; i < n; i++)
{
    string arr = Console.ReadLine();
	for (int j = 0; j < m; j++)
		board[i+1, j+1] = arr[j] - '0';
}

for (int i = 1;i <= n; i++)
{
	dp[i] = new int[105];
	Array.Fill(dp[i], int.MaxValue / 2);
}
dp[1][ 1] = 0;

PriorityQueue<Tuple<int, int , int>, int> pq = new PriorityQueue<Tuple<int, int, int>, int>();
pq.Enqueue(new Tuple<int, int, int>(dp[1][1], 1, 1), dp[1][1]);
while (pq.Count!= 0)
{
	var cur = pq.Dequeue();
	if (dp[cur.Item2][cur.Item3] != cur.Item1)
		continue;

	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item2 + dx[i];
		int ny = cur.Item3 + dy[i];
		if (nx <= 0 || ny <= 0 || nx > n || ny > m)
			continue;
		if(dp[nx][ny] > cur.Item1 + board[nx,ny])
		{
			dp[nx][ny] = cur.Item1 + board[nx, ny];
            pq.Enqueue(new Tuple<int, int, int>(dp[nx][ny], nx, ny), dp[nx][ ny]);
		}
	}
}

Console.WriteLine(dp[n][m]);

