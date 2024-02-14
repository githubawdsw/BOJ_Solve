// BOJ_17427


int n = int.Parse(Console.ReadLine());

long ans = 0;
for (int i = 1; i <= n; i++)
{
    ans += i * (n / i);
}

Console.WriteLine(ans);