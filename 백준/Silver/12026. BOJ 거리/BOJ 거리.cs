// BOJ_12026


int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

int[] dp = new int[1005];
dp[0] = 0;
for (int i = 1; i < n; i++)
{
    char cur = str[i];
    dp[i] = int.MaxValue / 2;
    if(cur == 'B')
    {
        for (int k = 0; k < i; k++)
        {
            if (str[k] == 'J')
                dp[i] = Math.Min(dp[i], dp[k] + (i - k) * (i - k));
        }
    }
    else if (cur == 'O')
    {
        for (int k = 0; k < i; k++)
        {
            if (str[k] == 'B')
                dp[i] = Math.Min(dp[i], dp[k] + (i - k) * (i - k));
        }
    }
    else
    {
        for (int k = 0; k < i; k++)
        {
            if (str[k] == 'O')
                dp[i] = Math.Min(dp[i], dp[k] + (i - k) * (i - k));
        }
    }

}


if (dp[n-1] == int.MaxValue / 2)
    Console.WriteLine(-1);
else
    Console.WriteLine(dp[n-1]);
