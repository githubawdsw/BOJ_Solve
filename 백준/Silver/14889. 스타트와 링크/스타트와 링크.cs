// BOJ_14889


int n = int.Parse(Console.ReadLine());
int[,] board = new int[25, 25];
bool[] check;

for (int i = 0; i < n; i++)
{
    string[] inputarr = Console.ReadLine().Split(' ');
	for (int j = 0; j < n; j++)
		board[i,j] = int.Parse(inputarr[j]);
	
}

int ans = int.MaxValue;
for (int i = 0; i < n; i++)
{
	check =  new bool[25];
	backTracking(i, 0);
}
Console.WriteLine(	ans);

void backTracking(int num, int count)
{
	if(count == n/2)
	{
		int start = 0;
		int link = 0;
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				if (i == j)
					continue;
				if (check[i] && check[j])
					start += board[i, j];
				else if (!check[i] && !check[j])
					link += board[i, j];
			}
		}
		ans = Math.Min(Math.Abs(start - link), ans);
		return;
	}

	for (int i = num; i < n; i++)
	{
		if (!check[i])
		{
			check[i] = true;
			backTracking(i, count + 1);
			check[i] = false;
		}
	}
}