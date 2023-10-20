// BOJ_6236



int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<int> withdraw = new List<int>();
for (int i = 0; i < n; i++)
    withdraw.Add(int.Parse(Console.ReadLine()));

int left = 0;
int right = int.MaxValue;
int ans = 0;
while (left <= right)
{
    int mid = (left + right) / 2;

    int remain = 0;
    int count = 0;
    bool check = true;
    for (int i = 0; i < n; i++)
    {
        if (withdraw[i] > mid)
        {
            check = false;
            break;
        }
        if (withdraw[i] > remain)
        {
            remain = mid;
            count++;
        }
        remain -= withdraw[i];
    }

    if (count > m || !check)
        left = mid + 1;
    else
    {
        ans = mid;
        right = mid - 1;
    }
}

Console.WriteLine( ans );
