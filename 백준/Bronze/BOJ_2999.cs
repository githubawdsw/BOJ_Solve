// BOJ_2999


string inputstr = Console.ReadLine();
int n = inputstr.Length;
int r = 0, c = 1;
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        c = i;
        r = n / c;
    }
    if (c >= r)
        break;
}

string ans = "";
for (int i = 0; i < r; i++)
    for (int j = 0; i + j < n; j+=r)
        ans += inputstr[i + j];

Console.WriteLine(  ans);
