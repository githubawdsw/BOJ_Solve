// BOJ_16472


int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

int[] used = new int[28];

int ans = 0;
int count = 0;
int start = 0;
int end = 0;
while (end < str.Length )
{
	int idx = str[end] - 'a';
	if (used[idx]++ == 0)
		count++;

	while(n < count && start < end)
	{
		if (--used[str[start++] - 'a'] == 0)
			count--;
	}
	ans = Math.Max(ans, end - start + 1);
	end++;
}

Console.WriteLine(ans);