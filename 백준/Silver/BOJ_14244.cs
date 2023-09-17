// BOJ_14244


using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

for (int i = 0; i < n - 1; i++)
{
    if (i < n - m)
        sb.AppendLine($"{i} {i + 1}");
    else
        sb.AppendLine($"{n - m} {i + 1}");
}
Console.WriteLine(sb);
