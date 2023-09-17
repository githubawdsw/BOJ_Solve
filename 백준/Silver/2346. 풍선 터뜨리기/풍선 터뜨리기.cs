// BOJ_2346


using System.Text;

int n = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');

Dictionary<int,int> dic = new Dictionary<int,int>();
List<int> list = new List<int>();
for (int i = 1; i <= n; i++)
{
    list.Add(i);
    dic.Add(i, int.Parse(inputarr[i - 1]));
}

StringBuilder sb = new StringBuilder();
int idx = 0;
while (list.Count > 0)
{
    sb.Append($"{list[idx]} ");
    int temp = 0;
    if (dic[list[idx]] >= 0)
        temp = idx + dic[list[idx]] - 1;
    else
        temp = idx + dic[list[idx]];

    list.RemoveAt(idx);
    if (list.Count == 0)
        break;

    idx = temp;
    while (idx < 0)
        idx += list.Count;
    while(idx >= list.Count)
        idx -= list.Count;
}
Console.WriteLine(  sb);

