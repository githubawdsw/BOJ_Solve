// BOJ_1895


int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];

int[,] board = new int[50, 50];
for (int i = 0; i < r; i++)
{
    string[] inputData = Console.ReadLine().Split();
    for (int j = 0; j < c; j++)
	{
        board[i, j] = int.Parse(inputData[j]);
	}
}

int t = int.Parse(Console.ReadLine());

List<int> list = new List<int>();
int ans = 0;
for (int i = 0; i <= r - 3; i++)
{
	for (int j = 0; j <= c - 3; j++)
	{
		List<int> filter = new List<int>();
		for (int x = 0; x < 3; x++)
		{
			for (int y = 0; y < 3; y++)
			{
				filter.Add(board[i + x, j + y]);
			}
		}
		filter.Sort();
		list.Add(filter[4]);
	}
}

for (int i = 0; i < list.Count; i++)
{
	if (list[i] >= t)
		ans++;
}

Console.WriteLine(ans);