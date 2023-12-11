// BOJ_1083


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());
int[] inputarr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int s = int.Parse(Console.ReadLine());

for (int i = 0; i < n - 1; i++)
{
    int index = FindMaxValue(i, s);

    for (int j = index; j > i; j--)
    {
        int temp = inputarr[j - 1];
        inputarr[j - 1] = inputarr[j];
        inputarr[j] = temp;
        s--;
    }

    if (s <= 0)
        break;
}

for (int i = 0; i < n; i++)
    sb.Append($"{inputarr[i]} ");

Console.WriteLine(sb);


int FindMaxValue(int idx , int end)
{
    int maxIndex = 0;
    int maxValue = 0;
    end = Math.Min(idx + end, n - 1);
    for (int i = idx; i <= end; i++)
    {
        if (inputarr[i] > maxValue)
        {
            maxValue = inputarr[i];
            maxIndex = i;
        }
    }
    return maxIndex;
}

