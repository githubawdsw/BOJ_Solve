// BOJ_10517


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[55, 55];
for (int i = 0; i < n; i++)
{
    string inputinfo = Console.ReadLine();
	for (int j = 0; j < m; j++)
		board[i, j] = inputinfo[j] - '0';
}

int ans = 1;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		int target = board[i, j];
		int length = 0;
		while (i + length < n && j + length < m)
		{
			if (board[i + length, j] == target && board[i, j + length] == target && board[i + length, j + length] == target)
				ans = Math.Max(ans, (length + 1) * (length + 1));
			length++;
		}
	}
}

Console.WriteLine(ans);
