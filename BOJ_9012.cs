// BOJ_9012


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
while (n-- > 0)
{
    string input = Console.ReadLine();
    Stack<char> s = new Stack<char>();
    bool check = false;
    char prev = ' ';

    if(input[0] == ')')
    {
        sb.AppendLine("NO");
        continue;
    }

    for (int i = 0; i < input.Length; i++)
    {
        if (s.Count == 0 && input[i] == ')')
        {
            check = true;
            break;
        }
        if (s.Count == 0 || prev == input[i])
            s.Push(input[i]);
        else if (prev != input[i])
            s.Pop();
        if(s.Count != 0)
            prev = s.Peek();
    }
    if (s.Count != 0 || check)
        sb.AppendLine("NO");
    else
        sb.AppendLine("YES");
}
Console.WriteLine(sb);
    