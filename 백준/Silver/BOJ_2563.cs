// BOJ_2563


int n = int.Parse(Console.ReadLine());

int[,] board = new int[105, 105];
for (int i = 0; i < n; i++)
{
    string[] inputxy = Console.ReadLine().Split(' ');
	int x = int.Parse(inputxy[0]);
	int y = int.Parse(inputxy[1]);

    for (int j = x; j < x + 10; j++)
		for (int k = y; k < y + 10; k++)
			board[j, k]++;
}
int ans = 0;
for (int i = 1; i < 101; i++)
{
	for (int j = 1; j < 101; j++)
	{
		if (board[i, j] != 0)
			ans++;
	}
}
Console.WriteLine(	ans);
