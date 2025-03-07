// BOJ_2697


using System.Text;

StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    string input = Console.ReadLine();
    char[] tochar = input.ToCharArray();

    int idx = input.Length - 1;
    while (idx - 1 > 0 && tochar[idx - 1] >= tochar[idx])
    {
        idx--;
    }

    idx--;
    if (idx == 0)
    {
        sb.AppendLine("BIGGEST");
        continue;
    }

    int target = input.Length - 1;
    while (tochar[target] <= tochar[idx])
    {
        target--;
    }
    (tochar[target], tochar[idx]) = (tochar[idx], tochar[target]);

    Array.Sort(tochar, idx + 1, input.Length - 1 - idx);
    sb.AppendLine(new string(tochar));
    
}

Console.WriteLine(sb);