//  BOJ_1305


int l = int.Parse(Console.ReadLine());
string s = Console.ReadLine();

int[] failure = new int[s.Length];
int j = 0;
for (int i = 1; i < s.Length; i++)
{
    while (j > 0 && s[i] != s[j])
        j = failure[j - 1];
    if (s[i] == s[j])
        failure[i] = ++j;
}

Console.WriteLine(  l - failure[l - 1]);
