// BOJ_5966



using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb= new StringBuilder();

while (n-- > 0)
{
    string[] inputkstr = Console.ReadLine().Split(' ');
    int k = int.Parse(inputkstr[0]);
    string str = inputkstr[1];

    bool check = false;
    Stack<char> s = new Stack<char>();
    for (int i = 0; i < k; i++)
    {
        if (str[i] == '>')
            s.Push('>');
        else if (str[i] == '<' && s.Count == 0)
        {
            check = true;
            break;
        }
        else
            s.Pop();
    }
    if(check || s.Count > 0)
        sb.AppendLine("illegal");
    else
        sb.AppendLine("legal");
}

Console.WriteLine(  sb);
