// BOJ_2792


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<int> beadList = new List<int>();
for (int i = 0; i < m; i++)
{
    int value = int.Parse(Console.ReadLine());
    beadList.Add(value);
}

beadList.Sort();

int start = 1;
int end = int.MaxValue / 2;
int ans = int.MaxValue;
while (start <= end)
{
    int mid = (start + end) / 2;
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        count += beadList[i] / mid;
        if (beadList[i] % mid != 0)
            count++;
    }

    if (count <= n)
    {
        end = mid - 1;
        ans = Math.Min(ans, mid);
    }
    else if (count > n)
        start = mid +1;
}

Console.WriteLine( ans );