// BOJ_20004


using System.Text;

StringBuilder sb = new StringBuilder();
int a = int.Parse(Console.ReadLine());

sb.AppendLine("1");

for (int i = 2; i <= a; i++)
{
	int end = 30;
	while (end > i)
	{
		end -= i + 1;
	}

	if (end <= 0)
		sb.AppendLine(i.ToString());
}

Console.WriteLine(sb);