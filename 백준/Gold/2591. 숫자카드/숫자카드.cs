// BOJ_2591


string str = Console.ReadLine();

int[] card = new int[50];
int[] dp = new int[50];

for (int i = 0; i < str.Length; i++)
{
    card[i] = str[i] - '0';
}

dp[0] = 1;
for (int i = 0; i < str.Length; i++)
{
    if (card[i] != 0)
    {
        dp[i + 1] += dp[i];
        if (card[i] * 10 + card[i + 1] >= 10 && card[i] * 10 + card[i + 1] <= 34)
            dp[i+2] += dp[i];
    }
}

Console.WriteLine(dp[str.Length]);