// BOJ_4358


using System.Text;

StringBuilder sb = new StringBuilder();
SortedDictionary<string, double> dict = new SortedDictionary<string, double>();
double count = 0;
while (true)
{
    string treeName = Console.ReadLine();
    if (treeName == null )
        break;
    if (!dict.ContainsKey(treeName))
        dict.Add(treeName, 0);
    dict[treeName]++;
    count++;
}

foreach (var one in dict)
{
    sb.AppendLine($"{one.Key} " + string.Format("{0:F4}" ,(one.Value / count) * 100));
}

Console.WriteLine(sb);