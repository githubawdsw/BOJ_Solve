// BOJ_1822


using System.Text;
StringBuilder sb = new StringBuilder();

string[] ab = Console.ReadLine().Split(' ');
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);
string[] ainput = Console.ReadLine().Split(' ');
string[] binput = Console.ReadLine().Split(' ');

List<int> alist = new List<int>();
List<int> blist = new List<int>();
for (int i = 0; i < a; i++)
    alist.Add(int.Parse(ainput[i]));
for (int i = 0; i < b; i++)
    blist.Add(int.Parse(binput[i]));

List<int> ans = new List<int>();
alist.Sort();
blist.Sort();
for (int i = 0; i < alist.Count; i++)
{
    if (blist.BinarySearch(alist[i]) < 0)
        ans.Add(alist[i]);
}
sb.AppendLine(ans.Count.ToString());
for (int i = 0; i < ans.Count; i++)
    sb.Append($"{ans[i]} ");
Console.WriteLine(sb);

