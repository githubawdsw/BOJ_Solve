// BOJ_10798


List< string> list = new List< string>();
int maxLength = 0;
for (int i = 0; i < 5; i++)
{
    string input = Console.ReadLine();
    list.Add(input);
    maxLength = Math.Max(maxLength, input.Length);
}

string ans = "";
for (int i = 0; i < maxLength; i++)
{
    for (int j = 0; j < 5; j++)
    {
        string str = list[j];
        if (i >= str.Length)
            continue;
        ans += str[i];
    }
}
Console.WriteLine(  ans);
