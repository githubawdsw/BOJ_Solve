// BOJ_25916


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int left = 0;
int right = 0;

int sum = 0;
int ans = 0;
while (right < n)
{
    if (sum + arr[right] <= m)
    {
        sum += arr[right];
        right++;
    }

    else
    {
        if (arr[left] > m)
        {
            right++;
            left++;
            continue;
        }
        sum -= arr[left];
        left++;
    }

    ans = Math.Max(ans, sum);
}

Console.WriteLine(ans);