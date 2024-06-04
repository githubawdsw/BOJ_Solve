// BOJ_1407


long[] inputab = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long a = inputab[0];
long b = inputab[1];

Console.WriteLine(Solve(b) - Solve(a - 1));

long Solve(long x)
{
    if (x == 0)
        return 0;
    else if (x == 1)
        return 1;

    if(x % 2 == 0)
    {
        return (x / 2) + 2 * Solve(x / 2);
    }
    else
    {
        return (x / 2) + (2 * Solve(x / 2)) + 1;
    }
}