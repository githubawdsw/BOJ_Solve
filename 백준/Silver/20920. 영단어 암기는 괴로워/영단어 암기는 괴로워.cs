// BOJ_20920


using System.Text;

string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

Dictionary<string, int> dict = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    string inputword = Console.ReadLine();
    if (inputword.Length < m)
        continue;
    if (!dict.ContainsKey(inputword))
        dict.Add(inputword, 1);
    else
        dict[inputword]++;
}
dict = dict.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key.Length)
    .ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

StringBuilder sb = new StringBuilder();
foreach (var one in dict)
    sb.AppendLine(one.Key);

Console.WriteLine( sb );