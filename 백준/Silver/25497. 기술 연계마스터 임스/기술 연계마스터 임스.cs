// BOJ_25497


int n = int.Parse(Console.ReadLine());
string arr = Console.ReadLine();

Stack<char> sl = new Stack<char>();
Stack<char> ss = new Stack<char>();
int count = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] == 'S')
        ss.Push(arr[i]);
    else if (arr[i] == 'L')
        sl.Push(arr[i]);
    else if (arr[i] == 'K' )
    {
        if (ss.Count == 0)
            break;
        char cur = ss.Pop();
        if (cur == 'S')
            count++;
    }
    else if (arr[i] == 'R')
    {
        if (sl.Count == 0)
            break;
        char cur = sl.Pop();
        if (cur == 'L')
            count++;
    }
    else
        count++;
}

Console.WriteLine(  count);
