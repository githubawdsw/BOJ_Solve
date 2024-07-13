// BOJ_11899


string str = Console.ReadLine();

int ans = 0;
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == ')' && count == 0)
        ans++;
    else if (str[i] == ')')
        count--;
    else if (str[i] == '(')
        count++;
}

if (count > 0)
    ans += count;

Console.WriteLine(ans);