// BOJ_10837


using System.Text;

StringBuilder sb = new StringBuilder();

int k = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
for (int i = 0; i < c; i++)
{
    int[] inputmn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int m = inputmn[0];
    int n = inputmn[1];

    if(m == n)
    {
        sb.AppendLine("1");
        continue;
    }

    int cur = k - Math.Max(m, n);
    int point = Math.Abs(m - n);
    if(m < n)
    {
        if (point - cur <= 1)
            sb.AppendLine("1");
        else
            sb.AppendLine("0");
    }
    else
    {
        if (point - cur <= 2)
            sb.AppendLine("1");
        else
            sb.AppendLine("0");
    }
}

Console.WriteLine(sb);
