// BOJ_21921

string[ ] inputnx = Console.ReadLine().Split(' ');
int n = int.Parse(inputnx[0]);
int x = int.Parse(inputnx[1]);

string[] inputarr = Console.ReadLine().Split(" ");

int[] dp = new int[250005];

for (int i = 0; i < x; i++)
    dp[x - 1] += int.Parse(inputarr[i]);

for (int i = x; i < n; i++)
    dp[i] = dp[i - 1] + int.Parse(inputarr[i]) - int.Parse(inputarr[i - x]);

int max = dp.Max();

if(max == 0)
{
    Console.WriteLine("SAD");
    return;
}

int count = 0;
for (int i = 0;i <= n; i++)
    if (dp[i] == max)
        count++;

Console.WriteLine( max);
Console.WriteLine( count );