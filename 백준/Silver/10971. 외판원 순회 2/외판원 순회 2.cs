// BOJ_10971

int n = int.Parse(Console.ReadLine());
int[,] board = new int[13, 13];
bool[] check = new bool[13];
int[] arr = new int[13];
for (int i = 0; i < n; i++)
{
    string[] inputarr = Console.ReadLine().Split(' ');
	for (int j = 0; j < n; j++)
		board[i, j] = int.Parse(inputarr[j]);
}
int ans = int.MaxValue;
for (int i = 0; i < n; i++)
{
	check[i] = true;
	backTracking(0, i , i);
	check[i] = false;
}
Console.WriteLine(	ans);


void backTracking(int count, int idx , int start)
{
	if(count == n - 1)
	{
		if (board[idx, start] == 0)
			return;
		int temp = 0;
		for (int i = 0; i < count; i++)
			temp += arr[i];
		temp += board[idx, start];
		ans = Math.Min(ans, temp);
		return;
	}

	for (int i = 0; i < n; i++)
	{
		if (!check[i] && board[idx, i] != 0)
		{
			check[i] = true;
			arr[count] = board[idx, i];
			backTracking(count + 1 , i , start);
			check[i] = false;
		}
	}
}