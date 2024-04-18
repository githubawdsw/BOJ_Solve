// BOJ_27172


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] inputCard = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] cardPos = new int[1000005];
int[] ans = new int[1000005];
for (int i = 0; i < n; i++)
{
	cardPos[inputCard[i]] = 1;
}

for (int i = 0; i < n; i++)
{
	int target = inputCard[i];
	for (int j = target * 2; j <= 1000000; j += target)
	{
		if (cardPos[j] == 1)
		{
			ans[target]++;
			ans[j]--;
		}
    }
}

for (int i = 0; i < n; i++)
{
	sb.Append($"{ans[inputCard[i]]} ");
}

Console.WriteLine(sb);