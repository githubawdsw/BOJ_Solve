// BOJ_1662


string input = Console.ReadLine();

Stack<char> s = new Stack<char>();

int idx = 0;
int[] countArr = new int[55];
int count = 0;
while (idx < input.Length)
{
    if (input[idx] == ')')
    {
        int cur = 0;
        while (s.Peek() != '(')
        {
            s.Pop();
            cur++;
        }
        s.Pop();
        int mul = s.Pop() - '0';
        int length = mul * (cur + countArr[count]);
        countArr[--count] += length;
        if(count != -1)
            countArr[count + 1] = 0;
    }
    else
    {
        s.Push(input[idx]);
        if (input[idx] == '(')
            count++;
    }
    idx++;
}

countArr[0] += s.Count;
Console.WriteLine(countArr[0]);