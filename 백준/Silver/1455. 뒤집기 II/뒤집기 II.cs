// BOJ_1455


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[105, 105];

for (int i = 0; i < n; i++)
{
	string inputLine = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputLine[j] - '0';
	}
}

int ans = 0;
for (int i = n - 1; i >= 0; i--)
{
	for (int j = m - 1; j >= 0; j--)
	{
        if (board[i, j] == 0)
            continue;

        ans++;
        for (int a = i; a >= 0; a--)
        {
            for (int b = j; b >= 0; b--)
            {
                board[a,b] = board[a,b] == 0 ? 1 : 0;
            }
        }
    }
}

Console.WriteLine(ans);