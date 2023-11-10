// BOJ_11687


int m = int.Parse(Console.ReadLine());

int start = 1;
int end = int.MaxValue / 2;

int ans = -1;
while (start <= end)
{
    int mid = (start + end) / 2;
	int count = 0;
	for (int i = 5; i <= mid; i *= 5)
	{
		count += mid / i;
	}
	if (count >= m)
	{
		end = mid - 1;
		if (count == m)
			ans = mid;
	}
	else
		start = mid + 1;
}

Console.WriteLine(ans);
