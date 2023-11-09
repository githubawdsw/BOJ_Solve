// BOJ_1976


int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[][] dp = new int[205][];
List<int> road = new List<int>();
for (int i = 1; i <= n; i++)
{
	dp[i] = new int[205];
	Array.Fill(dp[i], int.MaxValue / 2);
	string[] inputlink = Console.ReadLine().Split(' ');
	for (int j = 1; j <= n; j++)
		if (inputlink[j - 1] == "1")
			dp[i][j] = 1;
	dp[i][ i] = 0;
}

for (int i = 1; i <= n; i++)
    for (int j = 1; j <= n; j++)
        for (int k = 1; k <= n; k++)
			if (dp[j][k] > dp[j][i] + dp[i][k])
				dp[j][k] = dp[j][i] + dp[i][k];

string[] plan = Console.ReadLine().Split(' ');
for (int i = 0; i < m; i++)
	road.Add(int.Parse(plan[i]));

int start = 0;
int end = 1;
while (end < m )
{
	if(dp[road[start]][road[ end]] == int.MaxValue/2)
	{
        Console.WriteLine(	"NO");
		return;
    }
	start++;
	end++;
}
Console.WriteLine(	"YES");
