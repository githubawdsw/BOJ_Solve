
using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- >0)
{
    int n = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 1)
            sum += i;
    }
    sb.AppendLine(sum.ToString());
}
Console.WriteLine(sb);
