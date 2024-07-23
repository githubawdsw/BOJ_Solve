// BOJ_19951


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] inputHeight = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] dp = new int[100005];
for (int i = 0; i < m; i++)
{
    int[] inputOrder = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputOrder[0];
    int b = inputOrder[1];
    int k = inputOrder[2];

    dp[a - 1] += k;
    dp[b] += -k;
}

int cur = dp[0];
for (int i = 1; i < n; i++)
{
    dp[i] += cur;
    cur = dp[i];
}

for (int i = 0; i < n; i++)
{
    sb.Append($"{inputHeight[i] + dp[i]} ");
}

Console.WriteLine(sb);