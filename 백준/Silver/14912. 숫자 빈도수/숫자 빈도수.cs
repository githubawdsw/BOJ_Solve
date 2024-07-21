// BOJ_14912


int[] inputnd = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnd[0];
int d = inputnd[1];

int[] count = new int[11];

for (int i = 1; i <= n; i++)
{
    int value = i;
    while (value != 0)
    {
        count[value % 10]++;
        value /= 10;
    }
}

Console.WriteLine(count[d]);