// BOJ_2851


int ans = 0;
for (int i = 0; i < 10; i++)
{
    int input = int.Parse(Console.ReadLine());
    if (Math.Abs(100 - ans) >= Math.Abs(100 - (ans + input)))
        ans += input;
    else
        break;
}
Console.WriteLine(ans);
