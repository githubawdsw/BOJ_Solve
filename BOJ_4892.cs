
using System.Text;

StringBuilder sb = new StringBuilder();
int n;
int count = 1;
while (true)
{
    n = int.Parse(Console.ReadLine());
    if (n == 0)
        break;
    sb.Append($"{count++}. ");
    int find = n / 2;
    if (n % 2 == 0)
        sb.AppendLine($"even {find}");
    else
        sb.AppendLine($"odd {find}");
                
}
Console.WriteLine(sb);

