// BOJ_6591


using System.Text;

StringBuilder sb = new StringBuilder();


while (true)
{
    int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int n = inputnk[0];
    int k = inputnk[1];

    if (n == 0 && k == 0)
        break;

    long ans = 1;
    int max = Math.Max(k, n - k);
    int min = Math.Min(k, n - k);
    int idx = 1;
    for (int i = max + 1; i <= n; i++)
    {
        ans *= i;
        if(idx <= min)
        {
            ans /= idx;
            idx++;
        }    
    }

    sb.AppendLine(ans.ToString());
}

Console.WriteLine(sb);