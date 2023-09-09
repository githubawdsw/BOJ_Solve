// BOJ_3986
  

int n = int.Parse(Console.ReadLine());
int ans = 0;
while (n-- > 0)
{
    string inputstring = Console.ReadLine();
    Stack<char> s = new Stack<char>();
    int idx = 0;
    char top = ' ';
    while (idx < inputstring.Length)
    {
        if (s.Count == 0 || top != inputstring[idx])
            s.Push(inputstring[idx]);
        else if (top == inputstring[idx])
            s.Pop();
        if (s.Count != 0)
            top = s.Peek();
        idx++;
    }

    if (s.Count == 0)
        ans++;
}
Console.WriteLine(ans);
