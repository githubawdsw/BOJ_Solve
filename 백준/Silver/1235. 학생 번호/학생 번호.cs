// BOJ_1235


int n = int.Parse(Console.ReadLine());
List<string> list = new List<string>();
for (int i = 0; i < n; i++)
{
    list.Add(Console.ReadLine());
}

int length = list[0].Length;
for (int i = 0; i < length; i++)
{
	HashSet<string> hs = new HashSet<string>();
	for (int j = 0; j < n; j++)
	{
        string str = "";
        for (int k = length - 1; k >= length - 1 - i; k--)
        {
            str += list[j][k];
        }
        hs.Add(str);
    }
    if (hs.Count == n)
    {
        Console.WriteLine(i + 1);
        break;
    }
}

