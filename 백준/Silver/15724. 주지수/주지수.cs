// BOJ_15724


using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

int[,] board = new int[1030, 1030];
int[,] dp = new int[1030, 1030];
for (int i = 0; i < n; i++)
{
    string[] inputAmount = Console.ReadLine().Split(' ');
	for (int j = 0; j < m; j++)
		board[i + 1, j + 1] = int.Parse(inputAmount[j]);
}

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= m; j++)
        dp[i,j] = dp[i-1,j] + dp[i,j-1] - dp[i-1,j-1] + board[i,j];
}

int k = int.Parse(Console.ReadLine());
for (int i = 0; i < k; i++)
{
    string[] inputxy = Console.ReadLine().Split(' ');
    int x1 = int.Parse(inputxy[0]);
    int y1 = int.Parse(inputxy[1]);
    int x2 = int.Parse(inputxy[2]);
    int y2 = int.Parse(inputxy[3]);

    sb.AppendLine((dp[x2, y2] - dp[x2, y1 - 1] - dp[x1 - 1, y2] + dp[x1 - 1, y1 - 1]).ToString());
}

Console.WriteLine(  sb );
