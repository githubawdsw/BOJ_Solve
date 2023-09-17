// BOJ_1010



using System.Text;

int t = int.Parse(Console.ReadLine());
int[,] dp = new int[35, 35];
dp[0, 0] = 1;
for (int i = 1; i < 35; i++)
{
    dp[i, 0] = 1;
    dp[i, i] = 1;
    for (int j = 1; j <= i; j++)
        dp[i, j] = dp[i - 1, j] + dp[i - 1, j - 1];
}
    
StringBuilder sb = new StringBuilder();
while (t-- > 0)
{
    string[] inputnm = Console.ReadLine().Split(' ');
    int n = int.Parse(inputnm[0]);
    int m = int.Parse(inputnm[1]);
    sb.AppendLine(dp[m, n].ToString());
}
Console.WriteLine(  sb);

