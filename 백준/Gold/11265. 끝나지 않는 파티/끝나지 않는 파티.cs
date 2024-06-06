// BOJ_11265

using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] dp = new int[505, 505];
for (int i = 0; i < n; i++)
{
    int[] inputT = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < n; j++)
	{
		dp[i, j] = inputT[j];
	}
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            if (dp[j, k] > dp[j, i] + dp[i, k])
                dp[j, k] = dp[j, i] + dp[i, k];
        }
    }
}

for (int i = 0; i < m; i++)
{
    int[] inputabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = inputabc[0];
    int b = inputabc[1];
    int c = inputabc[2];

    if (dp[a - 1, b - 1] > c)
        sb.AppendLine("Stay here");
    else
        sb.AppendLine("Enjoy other party");
}

Console.WriteLine(sb);