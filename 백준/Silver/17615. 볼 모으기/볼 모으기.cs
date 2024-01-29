// BOJ_17615


int n = int.Parse(Console.ReadLine());
string arr = Console.ReadLine();

int ans = change('R');
ans = Math.Min(change('B'), ans);

Console.WriteLine(ans);


int change(char c)
{
	int totalCount = 0; int leftCount = 0; int rightCount = 0;
	for (int i = 0; i < n; i++)
	{
		if (arr[i] == c)
			totalCount++;
	}
	for (int i = 0; i < n; i++)
    {
		if (arr[i] == c)
			leftCount++;
		else
			break;
    }
	for (int i = n - 1; i >= 0; i--)
	{
        if (arr[i] == c)
            rightCount++;
        else
            break;
    }

	return totalCount - Math.Max(leftCount, rightCount);
}