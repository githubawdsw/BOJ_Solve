// BOJ_12931


int n = int.Parse(Console.ReadLine());
int[] inputArrb = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int ans = 0;
int max = 0;
for (int i = 0; i < n; i++)
{
    int pow = 0;
    int count = 0;
    int value = inputArrb[i];
    while (value != 0)
    {
        if (value % 2 == 0)
        {
            value /= 2;
            pow++;
        }
        else
        {
            value--;
            count++;
        }
    }
    ans += count;
    max = Math.Max(max, pow);
}

Console.WriteLine(ans + max);