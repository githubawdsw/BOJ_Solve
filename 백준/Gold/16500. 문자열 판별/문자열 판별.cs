// BOJ_16500



string s = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
HashSet<string> hs = new HashSet<string>();
bool[] check = new bool[105];

for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    hs.Add(str);
}

for (int i = s.Length - 1; i >= 0; i--)
{
    for (int j = i + 1; j < s.Length; j++)
    {
        if (check[j])
        {
            if (hs.Contains(s.Substring(i, j - i)))
            {
                check[i] = true;
                break;
            }
        }
    }
    if (hs.Contains(s.Substring(i)))
        check[i] = true;
}

if (check[0])
    Console.WriteLine(1);
else
    Console.WriteLine(0);