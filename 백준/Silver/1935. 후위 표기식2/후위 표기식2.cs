// BOJ_1935



int n = int.Parse(Console.ReadLine());
string inputcal = Console.ReadLine();

Dictionary<char , int> dict = new Dictionary<char , int>();
for (int i = 0; i < n; i++)
    dict[Convert.ToChar(i + 'A')] = int.Parse(Console.ReadLine());

Stack<double> s = new Stack<double>();
for (int i = 0; i < inputcal.Length; i++)
{
    if(inputcal[i] != '+' && inputcal[i] != '-' && inputcal[i] != '*' && inputcal[i] != '/')
        s.Push(dict[inputcal[i]]);
    else
    {
        double x = s.Pop();
        double y = s.Pop();
        if (inputcal[i] == '+')
            s.Push(x + y);
        else if (inputcal[i] == '-')
            s.Push(y - x);
        else if (inputcal[i] == '*')
            s.Push(x * y);
        else
            s.Push(y / x);
    }
}

Console.WriteLine( s.Peek().ToString("F2"));