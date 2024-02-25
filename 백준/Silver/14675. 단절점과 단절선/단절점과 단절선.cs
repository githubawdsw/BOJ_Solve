// BOJ_14675



using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
List<int>[] list = new List<int>[100005];
for (int i = 0; i < n - 1; i++)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputab[0];
    int b = inputab[1];

    if (list[a] == null)
        list[a] = new List<int>();
    list[a].Add(b);

    if (list[b] == null)
        list[b] = new List<int>();
    list[b].Add(a);
}

int q = int.Parse(Console.ReadLine());
for (int i = 0; i < q; i++)
{
    int[] inputtk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int t = inputtk[0];
    int k = inputtk[1];

    if (t == 2)
        sb.AppendLine("yes");
    else
    {
        if(list[k].Count == 1)
            sb.AppendLine("no");
        else
            sb.AppendLine("yes");
    }
}

Console.WriteLine(sb);

