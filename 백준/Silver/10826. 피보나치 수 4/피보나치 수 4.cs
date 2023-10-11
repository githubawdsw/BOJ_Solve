// BOJ_10826



int n = int.Parse(Console.ReadLine());
string[] dp = new string[10005];
dp[0] = "0";
dp[1] = "1";
for (int i = 2; i <= n; i++)
{
	string val = "";
	bool up = false;
	string rel = dp[i - 2];
	string rer = dp[i - 1];

	int idx;
    for (idx = 0; idx < rel.Length; idx++)
	{
		int left = rel[idx] - '0';
		int right = rer[idx] - '0';
		if (up)
			right++;
		if (left + right >= 10)
			up = true;
		else
			up = false;

		val += ((left + right) % 10).ToString();
    }

	for (int j = idx; j < rer.Length; j++)
	{
		int temp = rer[j] - '0';
		if (up)
			val += (temp + 1).ToString();
		else
			val += rer[j];
		up = false;
	}
	if (up)
		val += "1";
	dp[i] = val;
}

dp[n] = new string(dp[n].Reverse().ToArray());
Console.WriteLine(dp[n]);
