// BOJ_19699


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] inputH = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

SortedSet<int> ss = new SortedSet<int>();
bool[] vis = new bool[10];
bool[] notPrimeNum = new bool[10000];
notPrimeNum[1] = true;
for (int i = 2; i < 10000; i++)
{
	if (notPrimeNum[i])
		continue;
	for (int j = i + i; j < 10000; j += i)
	{
		notPrimeNum[j] = true;
	}
}

Dfs(0, 0);
foreach (var one in ss)
{
	sb.Append(one + " ");
}

if(ss.Count == 0)
    Console.WriteLine(-1);
else
	Console.WriteLine(sb);



void Dfs(int depth, int sum)
{
	if(depth == m)
	{
        if (!notPrimeNum[sum])
			ss.Add(sum);
		return;
	}

	for (int i = depth; i < n; i++)
    {
		if (vis[i])
			continue;
		vis[i] = true;
        Dfs(depth + 1, sum + inputH[i]);
		vis[i] = false;
	}
}