// BOJ_19538


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
List<int>[] list = new List<int>[200005];
for (int i = 0; i < n; i++)
{
    int[] inputRel = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
	list[i + 1] = new List<int>();
	for (int j = 0; j < inputRel.Length - 1; j++)
	{
		list[i + 1].Add(inputRel[j]);
	}
}

int m = int.Parse(Console.ReadLine());
int[] inputStart = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] count = new int[200005];
int[] ans = new int[200005];
Queue<int> q = new Queue<int>();

Array.Fill(ans, -1, 0, n + 1);
for (int i = 0; i < m; i++)
{
	ans[inputStart[i]] = 0;
	q.Enqueue(inputStart[i]);
}
for (int i = 1; i <= n; i++)
{
	count[i] = (list[i].Count + 1) / 2;
}

while (q.Count > 0)
{
	var cur = q.Dequeue();

	if (list[cur] == null)
		continue;

	foreach (var target in list[cur])
	{
		count[target] -= 1;
		if (ans[target] == -1 && count[target] <= 0)
		{
			q.Enqueue(target);
			ans[target] = ans[cur] + 1;
		}
	}
}

for (int i = 1; i <= n; i++)
{
	sb.Append(ans[i] + " ");
}

Console.WriteLine(sb);

