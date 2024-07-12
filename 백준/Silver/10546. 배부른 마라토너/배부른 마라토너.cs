// BOJ_10546


int n = int.Parse(Console.ReadLine());
Dictionary<string, int> dict = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    if(!dict.ContainsKey(name))
        dict.Add(name, 1);
    else
        dict[name]++;
}

for (int i = 0; i < n - 1; i++)
{
    string target = Console.ReadLine();
    dict[target]--;
    if (dict[target] == 0)
        dict.Remove(target);
}

Console.WriteLine(dict.First().Key);
