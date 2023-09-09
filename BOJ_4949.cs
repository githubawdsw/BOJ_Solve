// BOJ_4949


using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    Stack<char> s = new Stack<char>();
    string inputstring = Console.ReadLine();
    if (inputstring == ".")
        break;
    int idx = 0;
    char top = ' ';
    bool flag = false;
    while (idx < inputstring.Length)
    {
        if (inputstring[idx] == '[' || inputstring[idx] == '(')
            s.Push(inputstring[idx]);

        else if (inputstring[idx] == ']' || inputstring[idx] == ')')
        {
            if(s.Count == 0 )
            {
                flag = true;
                break;
            }

            top = s.Peek();
            if ((inputstring[idx] == ']' && top != '[') || (inputstring[idx] == ')' && top != '('))
            {
                flag = true;
                break;
            }
            s.Pop();
        }
        idx++;
    }
    if (flag || s.Count != 0)
        sb.AppendLine("no");
    else
        sb.AppendLine("yes");
}
Console.WriteLine(sb);
