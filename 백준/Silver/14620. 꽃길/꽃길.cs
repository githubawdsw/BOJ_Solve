// BOJ_14620


int n = int.Parse(Console.ReadLine());

int[,] board = new int[12, 12];
bool[,] used = new bool[12, 12];
for (int i = 0; i < n; i++)
{
    int[] inputCost = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	for (int j = 0; j < n; j++)
	{
		board[i, j] = inputCost[j];
	}
}

int ans = int.MaxValue;
Flower(0);


Console.WriteLine(ans);

void Flower(int counting)
{
	if(counting == 3)
	{
		int sum = 0;
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				if (used[i, j])
					sum += board[i, j];
			}
		}
		ans = Math.Min(sum, ans);

		return;
	}

	for (int i = 1; i < n - 1; i++)
	{
		for (int j = 1; j < n - 1; j++)
		{
			if (!used[i, j] && !used[i + 1, j] && !used[i - 1, j] && !used[i, j + 1] && !used[i, j - 1])
			{
				used[i,j] = true;
				used[i + 1, j] = true;
				used[i - 1, j] = true;
				used[i, j + 1] = true;
				used[i, j - 1] = true;

				Flower(counting + 1);

                used[i, j] = false;
                used[i + 1, j] = false;
                used[i - 1, j] = false;
                used[i, j + 1] = false;
                used[i, j - 1] = false;
            }
		}
	}
}