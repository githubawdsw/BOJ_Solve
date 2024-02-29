// BOJ_21758


int n = int.Parse(Console.ReadLine());
int[] inputHoney = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

long[] leftstart = new long[100005];
long[] rightstart = new long[100005];
for (int i = 1; i <= n; i++)
{
    leftstart[i] = inputHoney[i - 1] + leftstart[i - 1];
    rightstart[n - i + 1] = inputHoney[n - i] + rightstart[n - i + 1 + 1];
}

long ans = 0;
for (int i = 1; i <= n; i++)
{
    for (int j = i + 1; j <= n; j++)
    {
        for (int k = 1; k <= n; k++)
        {
            if (k == i || k == j)
                continue;

            long sum = 0;

            if (i < k)
            {
                sum += leftstart[k] - leftstart[i];
                if (j < k)
                    sum -= inputHoney[j - 1];
            }
            else
                sum += rightstart[k] - rightstart[i];

            if (j < k)
                sum += leftstart[k] - leftstart[j];
            else
            {
                sum += rightstart[k] - rightstart[j];
                if (i > k)
                    sum -= inputHoney[i - 1];
            }

            ans = Math.Max(sum, ans);
        }
    }
}

Console.WriteLine(ans);
