// BOJ_2257


string str = Console.ReadLine();

Stack<char> s = new Stack<char>();
Dictionary<char, int> dict = new Dictionary<char, int>
{
    { 'H', 1 }, { 'C', 12 } , { 'O', 16 }
};

for (int i = 0; i < str.Length; i++)
{
    s.Push(str[i]);
}

Console.WriteLine(Solve(1));


int Solve(int val)
{
    int sum = 0;
    int mul = 1;
    while (s.Count > 0)
    {
        var cur = s.Pop();

        if (cur == ')')
        {
            sum += Solve(mul);
            mul = 1;
        }
        else if (cur == '(')
        {
            return sum * val;
        }
        else if (cur == 'H' || cur == 'C' || cur == 'O')
        {
            sum += dict[cur] * mul;
            mul = 1;
        }
        else
        {
            mul = cur - '0';
        }
    }
    return sum;
}