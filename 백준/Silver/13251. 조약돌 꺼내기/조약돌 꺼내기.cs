// BOJ_13251


int m = int.Parse(Console.ReadLine());
int[] inputShingle = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int k = int.Parse(Console.ReadLine());

int n = inputShingle.Sum();

double ans = 0;
for (int i = 0; i < m; i++)
{
    if (inputShingle[i] < k)
        continue;
    double temp = 1;
    for (int j = 0; j < k; j++)
    {
        temp *= inputShingle[i] - j;
        temp /= n - j;
    }
    ans += temp;
}

Console.WriteLine(ans);
