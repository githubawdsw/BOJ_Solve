// BOJ_1764


using System.Text;

string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m = int.Parse(inputnm[1]);

List<string> nlist = new List<string>();
SortedSet<string> ans = new SortedSet<string>();
for (int i = 0; i < n; i++)
{
    string inputstr = Console.ReadLine();
    nlist.Add(inputstr);
}
nlist.Sort();
for (int i = 0; i < m; i++)
{
    string inputstr = Console.ReadLine();
    int idx = nlist.BinarySearch(inputstr);
    if (idx >= 0 && idx < n)
        ans.Add(inputstr);
}
StringBuilder sb = new StringBuilder();
sb.AppendLine(ans.Count.ToString());
foreach (var one in ans)
    sb.AppendLine(one);

Console.WriteLine(  sb);

