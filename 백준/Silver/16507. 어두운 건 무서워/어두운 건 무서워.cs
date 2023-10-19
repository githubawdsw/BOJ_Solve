// BOJ_16507



using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputrcq = Console.ReadLine().Split(' ');
int r = int.Parse(inputrcq[0]);
int c = int.Parse(inputrcq[1]);
int q = int.Parse(inputrcq[2]);

int[,] board = new int[1005, 1005];
int[,] dp = new int[1005, 1005];
for (int i = 0; i < r; i++)
{
    string[] inputk = Console.ReadLine().Split(' ');
	for (int j = 0; j < c; j++)
		board[i + 1,j + 1] = int.Parse(inputk[j]);
}
for (int i = 1; i <= r; i++)
{
	for (int j = 1; j <= c; j++)
		dp[i, j] = dp[i - 1, j] + dp[i, j - 1] - dp[i - 1, j - 1] + board[i,j];
}




for (int i = 0; i < q; i++)
{
	string[] inputPoint = Console.ReadLine().Split(" ");
	int r1 = int.Parse(inputPoint[0]);
	int c1 = int.Parse(inputPoint[1]);
	int r2 = int.Parse(inputPoint[2]);
	int c2 = int.Parse(inputPoint[3]);

	sb.AppendLine(((dp[r2, c2] - dp[r1 - 1, c2] - dp[r2, c1 - 1] + dp[r1 - 1, c1 - 1]) / ((r2 - r1 +1) * (c2 - c1 + 1))).ToString());
}

Console.WriteLine(	sb );