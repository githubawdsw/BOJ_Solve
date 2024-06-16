// BOJ_1451


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[55, 55];
for (int i = 0; i < n; i++)
{
    string inputInfo = Console.ReadLine();
    for (int j = 0; j < m; j++)
	{
		board[i, j] = inputInfo[j] - '0';
	}
}

long ans = 0;

long sum1 = 0;
for (int a = 0; a < n - 2; a++)
{
	for (int i = 0; i < m; i++)
	{
		sum1 += board[a, i];
	}

    long sum2 = 0;
	for (int b = a + 1; b < n - 1; b++)
	{
        for (int i = 0; i < m; i++)
        {
            sum2 += board[b, i];
        }

        long sum3 = 0;
		for (int c = b + 1; c < n; c++)
		{
			for (int i = 0; i < m; i++)
			{
				sum3 += board[c, i];
			}
		}

		ans = Math.Max(ans, sum1 * sum2 * sum3);
    }
}

sum1 = 0;
for (int a = 0; a < m - 2; a++)
{
    for (int i = 0; i < n; i++)
    {
        sum1 += board[i, a];
    }

    long sum2 = 0;
    for (int b = a + 1; b < m - 1; b++)
    {
        for (int i = 0; i < n; i++)
        {
            sum2 += board[i, b];
        }

        long sum3 = 0;
        for (int c = b + 1; c < m; c++)
        {
            for (int i = 0; i < n; i++)
            {
                sum3 += board[i, c];
            }
        }

        ans = Math.Max(ans, sum1 * sum2 * sum3);
    }
}

for (int x = 0; x < n - 1; x++)
{
    for (int y = 0; y < m - 1; y++)
    {
        sum1 = 0;
        long sum2 = 0;
        long sum3 = 0;

        for (int i = 0; i <= x; i++)
        {
            for (int j = 0; j <= y; j++)
            {
                sum1 += board[i, j];
            }
        }

        for (int i = 0; i <= x; i++)
        {
            for (int j = y + 1; j < m; j++)
            {
                sum2 += board[i, j];
            }
        }
        for (int i = x + 1; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sum3 += board[i, j];
            }
        }

        ans = Math.Max(ans, sum1 * sum2 * sum3);

        sum1 = 0;
        sum2 = 0;
        sum3 = 0;

        for (int i = 0; i <= x; i++)
        {
            for (int j = 0; j <= y; j++)
            {
                sum1 += board[i, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = y + 1; j < m; j++)
            {
                sum2 += board[i, j];
            }
        }
        for (int i = x + 1; i < n; i++)
        {
            for (int j = 0; j <= y; j++)
            {
                sum3 += board[i, j];
            }
        }

        ans = Math.Max(ans, sum1 * sum2 * sum3);

        sum1 = 0;
        sum2 = 0;
        sum3 = 0;

        for (int i = 0; i <= x; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sum1 += board[i, j];
            }
        }

        for (int i = x + 1; i < n; i++)
        {
            for (int j = y + 1; j < m; j++)
            {
                sum2 += board[i, j];
            }
        }
        for (int i = x + 1; i < n; i++)
        {
            for (int j = 0; j <= y; j++)
            {
                sum3 += board[i, j];
            }
        }

        ans = Math.Max(ans, sum1 * sum2 * sum3);

        sum1 = 0;
        sum2 = 0;
        sum3 = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= y; j++)
            {
                sum1 += board[i, j];
            }
        }

        for (int i = 0; i <= x; i++)
        {
            for (int j = y + 1; j < m; j++)
            {
                sum2 += board[i, j];
            }
        }
        for (int i = x + 1; i < n; i++)
        {
            for (int j = y + 1; j < m; j++)
            {
                sum3 += board[i, j];
            }
        }

        ans = Math.Max(ans, sum1 * sum2 * sum3);
    }
}

Console.WriteLine(ans);