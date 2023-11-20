// BOJ_11561


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    ulong n = ulong.Parse(Console.ReadLine());

    ulong start = 1;
    ulong end = n;
    ulong ans = 1;
    while (start <= end)
    {
        ulong mid = (start + end) / 2;

        ulong val = mid * (mid + 1) / 2;
        if (val <= n)
        {
            ans = mid;
            start = mid + 1;
        }
        else
            end = mid - 1;
    }
    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);
