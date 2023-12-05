// BOJ_17245


int n = int.Parse(Console.ReadLine());
Dictionary<int,int> dict = new Dictionary<int,int>();
long total = 0;
for (int i = 0; i < n; i++)
{
    int[] inputval = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < n; j++)
    {
        var value = inputval[j];
        if (value == 0)
            continue;
        if (!dict.ContainsKey(value))
            dict.Add(value, 0);
        dict[value]++;
        total += value;
    }
}

total = (total * 10 ) / 2;
long ans = 0;
long start = 0;
long end = 10000005;
while (start <= end)
{
    long mid = (start + end) / 2;

    long count = 0;
    foreach (var one in dict)
    {
        if (one.Key > mid)
            count += one.Value * mid;
        else
            count += one.Key * one.Value;
    }

    if (count * 10 >= total )
    {
        end = mid - 1;
        ans = mid;
    }
    else
    {
        start = mid + 1;
    }
}

Console.WriteLine(ans);