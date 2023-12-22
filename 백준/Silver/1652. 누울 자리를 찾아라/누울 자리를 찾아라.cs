// BOJ_1652


int n = int.Parse(Console.ReadLine());

char[,] board = new char[105, 105];

for (int i = 0; i < n; i++)
{
	string inputinfo = Console.ReadLine();
	for (int j = 0; j < n; j++)
		board[i, j] = inputinfo[j];
}

int ans1 = 0;
int ans2 = 0;
for (int i = 0; i < n; i++)
{
	int count = 0;
	for (int j = 0; j < n; j++)
	{
		if (board[i, j] == 'X')
		{
			if (count > 1)
				ans1++;
			count = 0;
			continue;
		}
		count++;
		if (j == n - 1 && count > 1)
			ans1++;
    }

	count = 0;
    for (int j = 0; j < n; j++)
    {
        if (board[j, i] == 'X')
        {
            if (count > 1)
                ans2++;
            count = 0;
            continue;
        }
        count++;
        if (j == n - 1 && count > 1)
            ans2++;
    }
}

Console.WriteLine($"{ans1} {ans2}");