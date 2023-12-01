//  BOJ_1786


using System.Text;

string t = Console.ReadLine();
string p = Console.ReadLine();

int[] f = failureFuc(p);
int j = 0;
List<int> idxList = new List<int>();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < t.Length; i++)
{
    while (j > 0 && t[i] != p[j])
        j = f[j - 1];
    if (t[i] == p[j])
        j++;
    if (j == p.Length)
    {
        idxList.Add(i - j + 2);
        j = f[j - 1];
    }
}
sb.AppendLine(idxList.Count.ToString());
for (int i = 0; i < idxList.Count; i++)
    sb.Append($"{idxList[i]} ");
Console.WriteLine( sb );

static int[] failureFuc(string str)
{
    int[] failure = new int[str.Length];
    int j = 0;
    for (int i = 1; i < str.Length; i++)
    {
        while (j > 0 && str[i] != str[j])
            j = failure[j - 1];
        if (str[i] == str[j])
            failure[i] = ++j;
    }
    return failure;
}