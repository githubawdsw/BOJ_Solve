// BOJ_11509


int n = int.Parse(Console.ReadLine());
int[] inputh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
bool[] balloon = new bool[1000005];

int ans = 0;
for (int i = 0; i < n; i++)
{
	int cur = inputh[i];
	if (balloon[i])
		continue;

	for (int j = i; j < n; j++)
	{
		if(cur == inputh[j] && !balloon[j])
		{
			cur--;
			balloon[j] = true;
		}
		if (cur == 0)
			break;
	}
	ans++;
}

Console.WriteLine(ans);