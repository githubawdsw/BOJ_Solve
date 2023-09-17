// BOJ_11328

using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
while (n-- > 0)
{
    string[] inputab = Console.ReadLine().Split(' ');
    if(inputab[0].Length != inputab[1].Length)
    {
        sb.AppendLine("Impossible");
        continue;
    }
    int length = inputab[0].Length;
    inputab[0] = String.Concat(inputab[0].OrderBy(x => x));
    inputab[1] = String.Concat(inputab[1].OrderBy(x => x));
    bool check = false;
    for (int i = 0; i < length; i++)
    {
        if(inputab[0][i] != inputab[1][i])
        {
            sb.AppendLine("Impossible");
            check = true;
            break;
        }
    }
    if (check)
        continue;
    sb.AppendLine("Possible");
}

Console.WriteLine(sb);

