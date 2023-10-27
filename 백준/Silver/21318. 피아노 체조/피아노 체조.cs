// BOJ_21318



using System.Text;

StringBuilder sb = new StringBuilder();

int n = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] dp = new int[100005];
for (int i = 1; i < n; i++)
{
    if (arr[i - 1] > arr[i])
        dp[i] = dp[i - 1] + 1;
    else
        dp[i] = dp[i - 1];
}

int q = int.Parse(Console.ReadLine());
for (int i = 0; i < q; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputxy[0];
    int y = inputxy[1];

    sb.AppendLine((dp[y - 1] - dp[x - 1]).ToString());
}

Console.WriteLine(  sb );
