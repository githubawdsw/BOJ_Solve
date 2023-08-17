
using System.Text;


int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
{
    string[] inputer = Console.ReadLine().Split(' ');
    int eat = int.Parse(inputer[0]);
    int require = int.Parse(inputer[1]);
    if (eat >= require)
        sb.AppendLine("MMM BRAINS");
    else
        sb.AppendLine("NO BRAINS");
}
Console.WriteLine(sb);