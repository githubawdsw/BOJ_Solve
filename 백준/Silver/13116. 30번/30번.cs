// BOJ_13116



using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
int[] par = new int[1030];
for (int i = 1; i <= 511; i++)
{
    par[i * 2] = i;
    par[i * 2 + 1] = i;
}
while (t-- > 0)
{
    int[] inputab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputab[0];
    int b = inputab[1];

    List<int> alist = new List<int>();
    List<int> blist = new List<int>();

    find(alist , a);
    find(blist , b);

    alist.Sort();
    blist.Sort();

    int minLength = Math.Min(alist.Count, blist.Count);
    int ans = 1;
    for (int i = 0; i < minLength; i++)
    {
        if (alist[i] == blist[i])
        {
            ans = Math.Max( alist[i], ans);
        }
        else
            break;
    }
    sb.AppendLine((ans * 10).ToString());
}

Console.WriteLine(  sb );



void find(List<int> list , int x)
{
    list.Add(x);
    if (x == 1)
        return;
    find(list, par[x]);
}