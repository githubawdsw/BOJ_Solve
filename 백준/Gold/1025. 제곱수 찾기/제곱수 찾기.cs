// BOJ_1025


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int m = inputnk[1];

int[,] board = new int[10, 10];
for (int i = 0; i < n; i++)
{
	string inputArr = Console.ReadLine();
	for (int j = 0; j < m; j++)
	{
		board[i, j] = inputArr[j] - '0';
	}
}

int ans = -1;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		for (int x = -n; x < n; x++)
		{
			for (int y = -m; y < m; y++)
			{
				if (x == 0 && y == 0)
					continue;

				int r = i;
				int c = j;
				int target = 0;
				while (r >= 0 && r < n && c >= 0 && c < m)
				{
					target *= 10;
					target += board[r, c];
					r += x;
					c += y;

					int sqrt = (int)Math.Sqrt(target);
					if(sqrt * sqrt == target)
						ans = Math.Max(ans, target);
				}
			}
		}
	}
}

Console.WriteLine(ans);