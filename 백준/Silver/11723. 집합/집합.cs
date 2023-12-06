// BOJ_11723

using System.Text;

StringBuilder sb = new StringBuilder();
SortedSet<int> ss = new SortedSet<int>();
int m = int.Parse(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    string fuc = input[0];
    int value = 0;
    if (fuc != "all" && fuc != "empty")
     value = int.Parse(input[1]);

    if (fuc == "add")
        ss.Add(value);
    
    else if (fuc == "remove")
        ss.Remove(value);

    else if (fuc == "check")
    {
        if (ss.Contains(value))
            sb.AppendLine("1");
        else
            sb.AppendLine("0");
    }

    else if (fuc == "toggle")
    {
        if (ss.Contains(value))
            ss.Remove(value);
        else
            ss.Add(value);
    }

    else if (fuc == "all")
    {
        for (int j = 1; j <= 20; j++)
            ss.Add(j);
    }

    else
        ss.Clear();
}

Console.WriteLine(sb);