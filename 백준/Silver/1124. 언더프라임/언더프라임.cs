// BOJ_1124


int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputab[0];
int b = inputab[1];

bool[] isNotPrimeNum = new bool[100005];
isNotPrimeNum[0] = true;
isNotPrimeNum[1] = true;
for (int i = 2; i <= b; i++)
{
	if (isNotPrimeNum[i])
		continue;
	for (int j = i + i; j <= b; j += i)
	{
		if (isNotPrimeNum[j])
			continue;
        isNotPrimeNum[j] = true;

	}
}

int ans = 0;
for (int i = a; i <= b; i++)
{
    int target = i;
	List<int> list = new List<int>();
	for (int j = 2; j <= target; j++)
	{
		while(target % j == 0)
		{
			list.Add(j);
			target /= j;
		}
	}
	if (!isNotPrimeNum[list.Count])
		ans++;
}

Console.WriteLine(ans);