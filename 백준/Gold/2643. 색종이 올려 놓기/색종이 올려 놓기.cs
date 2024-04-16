// BOJ_13302


int n = int.Parse(Console.ReadLine());
List<(int, int)> list = new List<(int, int)>();

for (int i = 0; i < n; i++)
{
    int[] inputLength = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int longLength = Math.Max(inputLength[0], inputLength[1]);
    int shortLength = Math.Min(inputLength[0], inputLength[1]);
    list.Add((shortLength, longLength));
}
list.Sort();

int[] dp = new int[105];
int ans = 1;
for (int i = 0; i < n; i++)
{
    dp[i] = 1;
    var cur = list[i];
    for (int j = 0; j < i; j++)
    {
        var target = list[j];
        if (target.Item1 <= cur.Item1 && target.Item2 <= cur.Item2)
            dp[i] = Math.Max(dp[i], dp[j] + 1);
    }
    ans = Math.Max(ans, dp[i]);
}

Console.WriteLine(ans);