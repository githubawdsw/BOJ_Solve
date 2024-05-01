// BOJ_16563


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] inputk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] prime = new int[5000005];
for (int i = 0; i <= 5000000; i++)
{
	prime[i] = i;
}

for (int i = 2; i <= 2500; i++)
{
	if (prime[i] != i)
		continue;
	for (int j = i; j <= 5000000; j += i)
	{
		if (prime[j] == j)
			prime[j] = i; 
	}
}

for (int i = 0; i < n; i++)
{
	int target = inputk[i];
	while (target != 1)
	{
		sb.Append($"{prime[target]} ");
		target /= prime[target];
	}
	sb.AppendLine();
}

Console.WriteLine(sb);