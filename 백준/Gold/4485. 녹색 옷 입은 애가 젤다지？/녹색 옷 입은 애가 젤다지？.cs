// BOJ_4485

using System.Text;

int[] dx = { 1, -1, 0, 0 };
int[] dy = { 0, 0, 1, -1 };
StringBuilder sb = new StringBuilder();
int count = 1;

while (true)
{
    int n = int.Parse(Console.ReadLine());
	if (n == 0)
		break;

	int[,] board = new int[130, 130];
	int[][] dp = new int[n + 1][];
	for (int i = 0; i < n; i++)
	{
		dp[i] = new int[n + 1];
		Array.Fill(dp[i], int.MaxValue / 2);
	}
	
	for (int i = 0; i < n; i++)
	{
		string[] inputmat = Console.ReadLine().Split(' ');
		for (int j = 0; j < n; j++)
			board[i, j] = int.Parse(inputmat[j]);
	}
	dp[0][0] = board[0, 0];

	PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
	pq.Enqueue(new Tuple<int, int>(0, 0), 0);
	while (pq.Count!= 0)
	{
		var cur = pq.Dequeue();
		for (int i = 0; i < 4; i++)
		{
			int nx = cur.Item1 + dx[i];
            int ny = cur.Item2 + dy[i];
			if (nx < 0 || ny < 0 || nx >= n || ny >= n)
				continue;
			if (dp[nx][ny] > dp[cur.Item1][cur.Item2] + board[nx, ny])
			{
				dp[nx][ny] = dp[cur.Item1][cur.Item2] + board[nx, ny];
				pq.Enqueue(new Tuple<int, int>(nx, ny), dp[nx][ny]);
			}
        }
	}
	sb.AppendLine($"Problem {count++}: {dp[n - 1][n - 1]}");
}
Console.WriteLine(	sb);

