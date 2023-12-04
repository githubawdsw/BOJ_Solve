// BOJ_23258

using System.Text;

int[,,] dp = new int[305,305,305];

string[] inputnq = Console.ReadLine().Split(' ');
int n = int.Parse(inputnq[0]);
int q = int.Parse(inputnq[1]);


for (int i = 1; i <= n; i++)
{
    string[] inputtime = Console.ReadLine().Split(' ');
    for (int j = 1; j <= n; j++)
    {
        dp[i,j,0] = int.Parse(inputtime[j - 1]);
        if (dp[i, j, 0] == 0 && i != j)
            dp[i, j, 0] = int.MaxValue / 2;
    }
}

for (int i = 1; i <= n; i++)
    for (int j = 1; j <= n; j++)
        for (int k = 1; k <= n; k++)
            dp[j, k, i] = Math.Min(dp[j, k, i - 1], dp[j, i, i - 1] + dp[i, k, i - 1]);

StringBuilder sb = new StringBuilder();
for (int i = 0; i < q; i++)
{
    string[] inputcse = Console.ReadLine().Split(' ');
    int c = int.Parse(inputcse[0]);
    int s = int.Parse(inputcse[1]);
    int e = int.Parse(inputcse[2]);
    if (dp[s, e, c - 1] == int.MaxValue / 2)
        sb.AppendLine("-1");
    else
        sb.AppendLine(dp[s, e, c - 1].ToString());
}
Console.WriteLine(  sb);