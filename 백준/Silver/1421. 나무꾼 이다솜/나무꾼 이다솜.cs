// BOJ_1421


int[] inputncw = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputncw[0];
int c = inputncw[1];
int w = inputncw[2];

List<int> tree = new List<int>();
for (int i = 0; i < n; i++)
{
    tree.Add(int.Parse(Console.ReadLine()));
}

long ans = 0;
int max = tree.Max();
for (int i = 1; i <= max; i++)
{
    long sum = 0;
    long cost = 0;
    for (int j = 0; j < n; j++)
    {
        long val = tree[j] / i;
        long count = val;
        if (tree[j] % i == 0)
            count--;

        if (val * w * i < count * c)
            continue;
        sum += val * w * i;
        cost += count * c;
    }

    if (ans < sum - cost)
        ans = sum - cost;
}

Console.WriteLine(ans);