// BOJ_1972


using System.Text;

StringBuilder sb = new StringBuilder();

string str = Console.ReadLine();
while (str != "*")
{
    int dis = str.Length - 1;
    bool check = false;
    while (dis > 0)
    {
        HashSet<string> hs = new HashSet<string>();
        for (int i = 0; i < str.Length; i++)
        {
            if (i + dis >= str.Length)
                break;

            if (!hs.Contains(str[i] + " " + str[dis + i]))
                hs.Add(str[i] + " " + str[dis + i]);
            else
            {
                check = true;
                break;
            }
        }
        if (check)
            break;
        dis--;
    }

    if (check)
        sb.AppendLine($"{str} is NOT surprising.");
    else
        sb.AppendLine($"{str} is surprising.");

    str = Console.ReadLine();
}

Console.WriteLine(sb);