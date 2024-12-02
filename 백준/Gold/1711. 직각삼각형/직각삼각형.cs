// BOJ_1711


int n = int.Parse(Console.ReadLine());
List<(long, long)> list = new List<(long, long)>();
for (int i = 0; i < n; i++)
{
    long[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
    long x = inputxy[0];
    long y = inputxy[1];

    list.Add((x, y));
}

long ans = 0;
for (int i = 0; i < n - 2; i++)
{
    var one = list[i];
    for (int j = i + 1; j < n - 1; j++)
    {
        var two = list[j];
        for (int k = j + 1; k < n; k++)
        {
            var thr = list[k];

            long line1 = (one.Item1 - two.Item1) * (one.Item1 - two.Item1) + (one.Item2 - two.Item2) * (one.Item2 - two.Item2);
            long line2 = (one.Item1 - thr.Item1) * (one.Item1 - thr.Item1) + (one.Item2 - thr.Item2) * (one.Item2 - thr.Item2);
            long line3 = (two.Item1 - thr.Item1) * (two.Item1 - thr.Item1) + (two.Item2 - thr.Item2) * (two.Item2 - thr.Item2);

            if (line1 + line2 == line3 || line2 + line3 == line1 || line3 + line1 == line2)
                ans++;
        }
    }
}

Console.WriteLine(ans);