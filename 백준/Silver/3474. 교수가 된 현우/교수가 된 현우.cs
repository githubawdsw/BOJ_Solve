// BOJ_3474


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    long n = long.Parse(Console.ReadLine());
	long count = 0;
	int five = 5;
	while(five <= n)
	{
		count += n / five;
		five *= 5;
    }
	sb.AppendLine(count.ToString());
}


Console.WriteLine(sb);
