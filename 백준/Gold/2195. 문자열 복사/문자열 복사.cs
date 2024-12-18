// BOJ_2195


string s = Console.ReadLine();
string p = Console.ReadLine();

string temp = "";
int ans = 0;
for (int i = 0; i < p.Length - 1; i++)
{
    temp += p[i];
    if(!s.Contains(temp + p[i + 1]))
    {
        ans++;
        temp = "";
    }
}
if (s.Contains(temp + p[p.Length - 1]))
    ans++;

Console.WriteLine(ans);