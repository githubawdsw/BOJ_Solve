// BOJ_20301


using System.Text;

StringBuilder sb = new StringBuilder();
string[] inputnkm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnkm[0]);
int k = int.Parse(inputnkm[1]);
int m = int.Parse(inputnkm[2]);

List<int> list = new List<int>();
for (int i = 1; i <= n; i++)
{
    list.Add(i);
}

int idx = -1;
int count = 0;

for (int i = 0; i < n - 1; i++)
{
    if (count < m)
        idx = RightDir(idx);
    else
        idx = LeftDir(idx);

    count++;
    if (count == 2 * m)
        count = 0;
}

sb.AppendLine(list[0].ToString());
Console.WriteLine(sb);


int RightDir(int idx)
{
    idx += k % list.Count;
    if(idx >= list.Count)
        idx -= list.Count;
    if (idx < 0)
        idx += list.Count;

    sb.AppendLine(list[idx].ToString());
    list.RemoveAt(idx);
    return idx - 1 < 0 ? list.Count - 1 : idx - 1;
}

int LeftDir(int idx)
{
    idx -= (k - 1) % list.Count;
    if (idx >= list.Count)
        idx -= list.Count;
    if (idx < 0)
        idx += list.Count;

    sb.AppendLine(list[idx].ToString());
    list.RemoveAt(idx);
    return idx - 1 < 0 ? list.Count - 1 : idx - 1;
}