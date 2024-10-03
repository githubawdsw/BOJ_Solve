// BOJ_14754


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[1005, 1005];
long sum = 0;
long count = 0;

for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        board[i, j] = inputInfo[j];
        board[i, m] = Math.Max(board[i, j], board[i, m]);
        board[n, j] = Math.Max(board[i, j], board[n, j]);
        sum += board[i, j];
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (board[i, j] < board[i, m] && board[i, j] < board[n, j])
            board[i, j] = 0;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        count += board[i, j];
    }
}

Console.WriteLine(sum - count);