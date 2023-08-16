// BOJ_10872


int n = int.Parse(Console.ReadLine());
int ans = 1;
if(n == 0)
{
    Console.WriteLine(  ans);
    return;
}

for (int i = 1; i <= n; i++)
    ans *= i;
Console.WriteLine(  ans);

