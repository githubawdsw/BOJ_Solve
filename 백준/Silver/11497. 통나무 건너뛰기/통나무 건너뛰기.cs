// BOJ_11497


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    string[] inputLarr = Console.ReadLine().Split(' ');

    List< int> list = new List< int>();
    for (int i = 0; i < n; i++)
        list.Add(int.Parse(inputLarr[i]));
    list.Sort();

    int ans = 0;
    for (int i = 0; i < n - 2; i ++)
        ans = Math.Max(Math.Abs(list[i] - list[i + 2]), ans);

    sb.AppendLine(ans.ToString());
}

Console.WriteLine(  sb );
