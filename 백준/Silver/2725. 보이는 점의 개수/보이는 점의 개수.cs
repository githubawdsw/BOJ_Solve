// BOJ_2725



using System.Text;

StringBuilder sb = new StringBuilder();
int c = int.Parse(Console.ReadLine());

int[] dp = new int[1005];
dp[1] = 3;
for (int i = 2; i <= 1000; i++)
{
    int sum = 0;
    for (int j = 1; j <= i; j++)
        if (GCD(i, j) == 1)
            sum++;
    dp[i] = dp[i - 1] + sum* 2;
}
while (c-- >0)
{
    int n = int.Parse(Console.ReadLine());
    sb.AppendLine(dp[n].ToString());
}
Console.WriteLine(  sb );


int GCD(int a, int b)
{
    if (b == 0)
        return a;
    return GCD(b, a% b);
}