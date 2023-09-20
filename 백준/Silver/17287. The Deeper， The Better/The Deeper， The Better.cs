// BOJ_17287



string inputarr = Console.ReadLine();

Stack<char> s = new Stack<char>();
int max = 0;
int sum = 0;
for (int i = 0; i < inputarr.Length; i++)
{
    if (inputarr[i] == '(')
        sum += 1;
    else if (inputarr[i] == '{')
        sum += 2;
    else if (inputarr[i] == '[')
        sum += 3;
    else if (inputarr[i] == ')')
        sum -= 1;
    else if (inputarr[i] == '}')
        sum -= 2;
    else if (inputarr[i] == ']')
        sum -= 3;
    else
        max= Math.Max(max, sum);
}

Console.WriteLine(  max);
