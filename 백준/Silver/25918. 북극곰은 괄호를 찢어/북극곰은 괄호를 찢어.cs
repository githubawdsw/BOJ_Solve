// BOJ_25918


int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

int ans = 0;
int idx = 0;
Stack<char> s = new Stack<char>();
while (idx < n)
{
    if(s.Count == 0)
    {
        s.Push(str[idx]);
    }
    else
    {
        if (s.Peek() == '(' && str[idx] == ')')
            s.Pop();
        else if (s.Peek() == ')' && str[idx] == '(')
            s.Pop();
        else
            s.Push(str[idx]);
    }

    ans = Math.Max(ans, s.Count);
    idx++;
}


if(s.Count > 0)
    Console.WriteLine(-1);
else
    Console.WriteLine(ans);