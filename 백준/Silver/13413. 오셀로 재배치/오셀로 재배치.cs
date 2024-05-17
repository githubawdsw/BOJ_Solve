// BOJ_13413


using System.Text;

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    string start = Console.ReadLine();
    int wCount = 0;
    int bCount = 0;
    for (int i = 0; i < n; i++)
    {
        if (start[i] == 'W')
            wCount++;
        else
            bCount++;
    }
    
    string end = Console.ReadLine();
    int targetW = 0;
    int targetB = 0;
    for (int i = 0; i < n; i++)
    {
        if (end[i] == 'W')
            targetW++;
        else
            targetB++;
    }

    int ans = 0;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (start[i] != end[i])
            ans++;
    }

    if (wCount - targetW > bCount - targetB)
        count = wCount - targetW;
    else
        count = bCount - targetB;

    if (count > 0)
        ans -= (ans - count) / 2;
    else
        ans /= 2;

    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);

