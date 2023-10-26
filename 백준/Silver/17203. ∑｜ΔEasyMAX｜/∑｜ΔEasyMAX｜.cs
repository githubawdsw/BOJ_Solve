// BOJ_17203



using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnq = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnq[0];
int q  = inputnq[1];

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] dp = new int[1005];
for (int i = 1; i < n; i++)
    dp[i] = dp[i - 1] + Math.Abs(arr[i] - arr[i - 1]);

for (int i = 0; i < q; i++)
{
    int[] inputpos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int q1 = inputpos[0];
    int q2 = inputpos[1];

    sb.AppendLine((dp[q2 - 1] - dp[q1 - 1]).ToString());
}

Console.WriteLine(  sb );