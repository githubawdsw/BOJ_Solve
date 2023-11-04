// BOJ_20438


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnkqm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnkqm[0];
int k = inputnkqm[1];
int q = inputnkqm[2];
int m = inputnkqm[3];

int[] present = new int[5005];
int[] inputDrowse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < inputDrowse.Length; i++)
    present[inputDrowse[i]] = 2;

int[] check = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < check.Length; i++)
    if (present[check[i]] != 2)
        for (int j = check[i]; j <= n + 2; j += check[i])
        {
            if (present[j] != 2)
                present[j] = 1;
        }

int[] dp = new int[5005];
for (int i = 3; i <= n+2; i++)
{
    dp[i] = dp[i - 1];
    if (present[i] != 1)
        dp[i]++;
}

for (int i = 0; i < m; i++)
{
    int[] inputse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int s = inputse[0];
    int e = inputse[1];
    sb.AppendLine($"{dp[e] - dp[s - 1]}");
}

Console.WriteLine(sb);
