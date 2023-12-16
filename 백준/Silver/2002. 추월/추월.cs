// BOJ_2002


int n = int.Parse(Console.ReadLine());
List<string> list = new List<string>();

for (int i = 0; i < n; i++)
{
    list.Add(Console.ReadLine());
}

string target = string.Empty;
HashSet<string> hs = new HashSet<string>();
int idx = 0;
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    if (target == string.Empty)
    {
        while (idx < n)
        {
            if (!hs.Contains(list[idx]))
            {
                target = list[idx++];
                break;
            }
            idx++;
        }
    }

    if (target != str)
        hs.Add(str);
    else
        target = string.Empty;
}

Console.WriteLine(hs.Count);