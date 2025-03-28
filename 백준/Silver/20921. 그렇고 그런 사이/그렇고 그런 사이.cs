// BOJ_20921


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

List<int> list = new List<int>();
bool[] check = new bool[4300];
int idx = 0;
while (idx < n && k > 0)
{
	for (int i = n - idx; i > 0; i--)
	{
		if (i - 1 <= k)
		{
			check[i] = true;
			k -= i - 1;
			list.Add(i);
			break;
		}
	}
	idx++;
}

for (int i = 0; i < list.Count; i++)
{
	sb.Append(list[i] + " ");
}

for (int i = 1; i <= n; i++)
{
	if (!check[i])
        sb.Append(i + " ");
}
Console.WriteLine(sb);