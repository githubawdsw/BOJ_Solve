// BOJ_15723


using System.Text;

StringBuilder sb = new StringBuilder();
int[][] dp = new int[30][];
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < 26; i++)
{
    dp[i] = new int[30];
    Array.Fill(dp[i], int.MaxValue / 2);
    dp[i][i] = 0;
}

for (int i = 0; i < n; i++)
{
    string[] inputrel = Console.ReadLine().Split(' ');
    int x = char.Parse(inputrel[0]) - 'a';
    int y = char.Parse(inputrel[2]) - 'a';
    dp[x][y] = 1;
}

for (int i = 0; i < 26; i++)
    for (int j = 0; j < 26; j++)
        for (int k = 0; k < 26; k++)
            if (dp[j][k] > dp[j][i] + dp[i][k])
                dp[j][k] = dp[j][i] + dp[i][k];

int m = int.Parse(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    string[] inputcheck = Console.ReadLine().Split(' ') ;
    int x = char.Parse(inputcheck[0]) - 'a';
    int y = char.Parse(inputcheck[2]) - 'a';
    if (dp[x][y] == int.MaxValue / 2)
        sb.AppendLine("F");
    else
        sb.AppendLine("T");
}

Console.WriteLine(  sb);

