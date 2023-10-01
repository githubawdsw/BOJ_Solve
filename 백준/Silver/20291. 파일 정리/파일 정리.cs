// BOJ_20291



using System.Text;

StringBuilder sb= new StringBuilder();
int n = int.Parse(Console.ReadLine());
Dictionary<string, int> dict = new Dictionary<string, int>();
for (int i = 0; i < n; i++)
{
    string[] inputinfo = Console.ReadLine().Split('.');
    if(!dict.ContainsKey(inputinfo[1]))
        dict.Add(inputinfo[1], 0);
    dict[inputinfo[1]]++;
}
dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

foreach (var one in dict)
    sb.AppendLine($"{one.Key} {one.Value}");

Console.WriteLine(  sb);
