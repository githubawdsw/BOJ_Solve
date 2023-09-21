// BOJ_11441


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
string[] inputarr = Console.ReadLine().Split(' ');

int[] dp = new int[100005];
dp[1] = int.Parse(inputarr[0]);
for (int idx = 1; idx < inputarr.Length; idx++)
    dp[idx + 1] = dp[idx] + int.Parse(inputarr[idx]);

int m = int.Parse(Console.ReadLine());
for (int x = 0; x < m; x++)
{
    string[] inputij = Console.ReadLine().Split(' ');
    int i = int.Parse(inputij[0]);
    int j = int.Parse(inputij[1]);
    sb.AppendLine((dp[j] - dp[i - 1]).ToString());
}

Console.WriteLine(  sb);
