// BOJ_4158




using System.Text;

StringBuilder sb= new StringBuilder();
while (true)
{
    string[] inputnm = Console.ReadLine().Split(' ');

    int n = int.Parse(inputnm[0]);
    int m = int.Parse(inputnm[1]);
    if (n == 0 && m == 0)
        break;

    HashSet<int> hs = new HashSet<int>();
    int ans = 0;
    for (int i = 0; i < n; i++)
    {
        int sgCd = int.Parse(Console.ReadLine());
        hs.Add(sgCd);
    }
    for (int i = 0; i < m; i++)
    {
        int syCd = int.Parse(Console.ReadLine());
        if (hs.Contains(syCd))
            ans++;
    }
    sb.AppendLine(ans.ToString());
}

Console.WriteLine(  sb );
