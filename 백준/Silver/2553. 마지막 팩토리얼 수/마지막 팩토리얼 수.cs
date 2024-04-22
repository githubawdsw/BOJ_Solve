// BOJ_2553


int n = int.Parse(Console.ReadLine());

long factorial = 1;
for (int i = 2; i <= n; i++)
{
    factorial *= i;
    while (factorial % 10 == 0)
    {
        factorial /= 10;
    }

    factorial %= 100000000000;
}

Console.WriteLine((factorial).ToString().Last());