// BOJ_1748



int n = int.Parse(Console.ReadLine());
int length = n.ToString().Length;

int ans = 0;
int sum = 0;
Solve();
Console.WriteLine(ans);

void Solve()
{
    for (int i = 1; i <= length; i++)
    {
        if (i == length)
            ans += i * (n - sum);
        else
        {
            int value = (int)Math.Pow(10, (i - 1)) * 9;
            sum += value;
            ans += i * value;
        }
    }
}