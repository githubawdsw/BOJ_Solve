// BOJ_24040


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    long n = long.Parse(Console.ReadLine());
	if(n % 9 == 0 || n % 3 == 2)
		sb.AppendLine("TAK");
	else
        sb.AppendLine("NIE");

}

Console.WriteLine(sb);
