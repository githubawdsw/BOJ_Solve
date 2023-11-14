// BOJ_8983



int[] inputmnl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = inputmnl[0];
int n = inputmnl[1];
int l = inputmnl[2];

int[] gun = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(gun);
int count = 0;

for (int i = 0; i < n; i++)
{
    int[] pos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (pos[1] > l)
        continue;

    int start = 0;
    int end = m - 1;
    while (start <= end)
    {
        int mid = (start + end) / 2;
        if (Math.Abs(pos[0] - gun[mid]) + pos[1] <= l)
        {
            count++;
            break;
        }
        if (pos[0] <= gun[mid])
            end = mid - 1;
        else
            start = mid + 1;
    }
}

Console.WriteLine(  count );