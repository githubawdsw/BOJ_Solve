//  BOJ_16916


string s = Console.ReadLine();
string p = Console.ReadLine();
int[] f = failureFuc(p);

int ans = 0;
int j = 0;
for (int i = 0; i < s.Length; i++)
{
    while (j > 0 && s[i] != p[j])
        j = f[j - 1];
    if (s[i] == p[j])
        j++;
    if (j == p.Length)
    {
        ans = 1;
        break;
    }
}
Console.WriteLine(  ans);

int[] failureFuc(string s)
{
    int[] f = new int[s.Length];
    int j = 0;
    for (int i = 1; i < s.Length; i++)
    {
        while (j > 0 && s[i] != s[j])
            j = f[j - 1];
        if (s[i] == s[j])
            f[i] = ++j;
    }
    return f;
}

