// BOJ_20044


int n = int.Parse(Console.ReadLine());
int[] inputw= Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(inputw);

int ans = int.MaxValue;
for (int i = 0; i < n; i++)
{
    ans = Math.Min(ans, inputw[i] + inputw[2 * n - i - 1]);
}

Console.WriteLine(ans);