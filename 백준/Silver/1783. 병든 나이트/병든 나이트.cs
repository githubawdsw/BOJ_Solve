// BOJ_1783


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m  = inputnm[1];

if (n == 1)
    Console.WriteLine(1);
else if (n == 2)
    Console.WriteLine(Math.Min(4, (m - 1) / 2 + 1));
else
{
    if (m < 7)
        Console.WriteLine(Math.Min(4, m));
    else
        Console.WriteLine(m - 2);
}
