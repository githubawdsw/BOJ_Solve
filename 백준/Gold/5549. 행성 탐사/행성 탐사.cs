// BOJ_5549


using System.Text;

StringBuilder sb = new StringBuilder();

int[] inputmn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = inputmn[0];
int n = inputmn[1];

int k = int.Parse(Console.ReadLine());

char[,] map = new char[1005, 1005];
for (int i = 0; i < m; i++)
{
	string info = Console.ReadLine();
	for (int j = 0; j < n; j++)
	{
		map[i, j] = info[j];
	}
}

int[,,] dp = new int[5,1005, 1005];
if (map[0, 0] == 'J')
	dp[1, 0, 0] = 1;
else if (map[0, 0] == 'O')
	dp[2, 0, 0] = 1;
else
	dp[3, 0, 0] = 1;

for (int i = 1; i < m; i++)
{
	for (int j = 1; j <= 3; j++)
	{
		dp[j, i, 0] = dp[j, i - 1, 0];
	}

	if (map[i, 0] == 'J')
		dp[1, i, 0]++;
	else if (map[i, 0] == 'O')
		dp[2, i, 0]++;
	else
        dp[3, i, 0]++;
}

for (int i = 1; i < n; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        dp[j, 0, i] = dp[j, 0, i - 1];
    }

    if (map[0, i] == 'J')
        dp[1, 0, i]++;
    else if (map[0, i] == 'O')
        dp[2, 0, i]++;
    else
        dp[3, 0, i]++;
}

for (int i = 1; i < m; i++)
{
	for (int j = 1; j < n; j++)
	{
        for (int t = 1; t <= 3; t++)
        {
			dp[t, i, j] = dp[t, i - 1, j] + dp[t, i, j - 1] - dp[t, i - 1, j - 1];
        }

        if (map[i, j] == 'J')
            dp[1, i, j]++;
        else if (map[i, j] == 'O')
            dp[2, i, j]++;
        else
            dp[3, i, j]++;
    }
}

for (int i = 0; i < k; i++)
{
	int[] inputabcd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	int a = inputabcd[0] - 1;
	int b = inputabcd[1] - 1;
	int c = inputabcd[2] - 1;
	int d = inputabcd[3] - 1;

	for (int t = 1; t <= 3; t++)
	{
		int ans = dp[t, c, d];
		if (a != 0)
			ans -= dp[t, a - 1, d];
		if (b != 0)
			ans -= dp[t, c, b - 1];
		if (a != 0 && b != 0)
			ans += dp[t, a - 1, b - 1];
		sb.Append($"{ans} ");
	}
	sb.AppendLine();
}

Console.WriteLine(sb);