// BOJ_1593


int[] inputgl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int g = inputgl[0];
int l = inputgl[1];

int[] wordCase = new int[55];
int[] compareCase = new int[55];
string w = Console.ReadLine();
string s = Console.ReadLine();

for (int i = 0; i < g; i++)
{
    if (w[i] - 'a' >= 0)
        wordCase[w[i] - 'a']++;
    else
        wordCase[w[i] - 'A' + 26]++;
}

int start = 0;
int end = g;
int ans = 0;

for (int i = 0; i < g; i++)
{
    if (s[i] - 'a' >= 0)
        compareCase[s[i] - 'a']++;
    else
        compareCase[s[i] - 'A' + 26]++;
}

if(g == l && wordCase.SequenceEqual(compareCase))
{
    ans++;
}

while (end < l)
{
    if (wordCase.SequenceEqual(compareCase))
    {
        ans++;
    }

    if (s[start] - 'a' >= 0)
        compareCase[s[start++] - 'a']--;
    else
        compareCase[s[start++] - 'A' + 26]--;

    if (s[end] - 'a' >= 0)
        compareCase[s[end++] - 'a']++;
    else
        compareCase[s[end++] - 'A' + 26]++;
}
if (wordCase.SequenceEqual(compareCase))
{
    ans++;
}

Console.WriteLine(ans);