// BOJ_5555


string word = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
List<string> list = new List<string>();
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    list.Add(str + str);
}

int ans = 0;
for (int i = 0; i < n; i++)
{
    var cur = list[i];
    if (cur.Contains(word))
        ans++;
}

Console.WriteLine(ans);
