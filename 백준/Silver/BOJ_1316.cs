// BOJ_1316



int n = int.Parse(Console.ReadLine());
int ans = 0;
for (int i = 0; i < n; i++)
{
    int[] alphabetCnt = new int[26];
    string str = Console.ReadLine();
    alphabetCnt[str[0] - 'a']++;
    bool check = true;
    for (int j = 1; j < str.Length; j++)
    {
        if (str[j] == str[j - 1] || (alphabetCnt[str[j] - 'a'] == 0 && str[j] != str[j - 1]))
            alphabetCnt[str[j] - 'a']++;
        else
            check = false;
    }
    if (check)
        ans++;
}
Console.WriteLine(  ans);

