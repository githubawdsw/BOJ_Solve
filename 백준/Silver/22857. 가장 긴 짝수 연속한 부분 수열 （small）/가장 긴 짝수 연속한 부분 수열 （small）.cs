// BOJ_22857


int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

int[] inputArrayS = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int start = 0;
for (int i = 0; i < n; i++)
{
    if (inputArrayS[i] % 2 == 0)
    {
        start = i;
        break;
    }
}

int end = start;
int ans = 0;
int count = 0;

while (end < n)
{
    if (inputArrayS[end] % 2 == 0)
    {
        ans = Math.Max(end - start - count + 1, ans);
    }
    else
    {
        count++;
    }

    end++;
    if (count > k)
    {
        while (count > k || inputArrayS[start] % 2 == 1)
        {
            if(inputArrayS[start] % 2 == 1)
                count--;
            start++;
            if (start >= n)
                break;
        }
    }
}

Console.WriteLine(ans);