// BOJ_12970


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnk[0];
int k = inputnk[1];

for (int a = 0; a <= n; a++)
{
    int b = n - a;

    if (a * b < k)
        continue;

    int[] arr = new int[55];
    for (int i = 0; i < a; i++)
    {
        int x = Math.Min(b, k);
        arr[x] += 1;
        k -= x;
    }

    for (int i = b; i >= 0; i--)
    {
        for (int j = 0; j < arr[i]; j++)
        {
            sb.Append('A');
        }
        if (i > 0)
            sb.Append('B');
    }

    Console.WriteLine(sb);
    return;
}

Console.WriteLine(-1);
