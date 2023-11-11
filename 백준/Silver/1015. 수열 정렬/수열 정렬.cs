// BOJ_1015


using System.Text;

StringBuilder sb =new StringBuilder();

int n = int.Parse(Console.ReadLine());
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] sort = new int[n];
Array.Copy(a, sort, n);
Array.Sort(sort);

int[] p = new int[n];
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		if (sort[i] == a[j])
		{
			p[j] = i;
			a[j] = int.MaxValue;
			break;
		}
	}
}

for (int i = 0; i < n; i++)
{
	sb.Append($"{p[i]} ");
}

Console.WriteLine(sb);

