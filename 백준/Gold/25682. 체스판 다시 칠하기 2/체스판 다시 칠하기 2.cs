// BOJ_25682



int[] inputnmk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmk[0];
int m = inputnmk[1];
int k = inputnmk[2];

char[,] board = new char[2005, 2005];
int[,] whiteStart = new int[2005, 2005];
int[,] blackStart = new int[2005, 2005];
for (int i = 1; i <= n; i++)
{
	string s = Console.ReadLine();
	for (int j = 1; j <= m; j++)
        board[i, j] = s[j - 1];
}

int ans = Math.Min(dp('B'), dp('W'));

Console.WriteLine(ans);


int dp(char color)
{
    int[,] sum = new int[2005, 2005];
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= m; j++)
        {
            int value = 0;
            if ((i + j) % 2 == 0)
                value = board[i, j] != color ? 1 : 0;
            else
                value = board[i, j] == color ? 1 : 0;
            sum[i, j] = sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1] + value;
        }
    }

    int count = int.MaxValue;
    for (int i = k; i <= n; i++)
    {
        for (int j = k; j <= m; j++)
        {
            count = Math.Min(count, sum[i, j] - sum[i - k, j] - sum[i, j - k] + sum[i - k, j - k]);
        }
    }

    return count;
}
