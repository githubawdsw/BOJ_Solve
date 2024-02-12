// BOJ_4889


using System.Text;

StringBuilder sb = new StringBuilder();
int count = 0;
while (true)
{
    string strInput = Console.ReadLine();
    if (strInput[0] == '-')
        break;

    Stack<char> openStack = new Stack<char>();
    int ans = 0;
    count++;

    for (int i = 0; i < strInput.Length; i++)
    {
        if (strInput[i] == '{')
        {
            openStack.Push(strInput[i]);
        }

        else if (strInput[i] == '}')
        {
            if (openStack.Count == 0)
            {
                ans++;
                openStack.Push(strInput[i]);
            }
            else
                openStack.Pop();
        }
    }
    ans += openStack.Count / 2;
    sb.AppendLine(count.ToString() + ". " + ans.ToString());
}

Console.WriteLine(sb);
