// BOJ_20207


int n = int.Parse(Console.ReadLine());

int[] overlap = new int[370];
for (int i = 0; i < n; i++)
{
    int[] inputse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int s = inputse[0];
    int e = inputse[1];

    for (int j = s; j <= e; j++)
    {
        overlap[j]++;
    }
}

int sum = 0;
int min = int.MaxValue;
int max = 0;
int count = 0;
for (int i = 1; i <= 366; i++)
{
    if (overlap[i] == 0)
    {
        sum += (max - min + 1) * count;
        min = int.MaxValue;
        max = 0;
        count = 0;
    }
    else
    {
        min = Math.Min(min, i);
        max = Math.Max(max, i);
        count = Math.Max(count, overlap[i]);
    }
}

Console.WriteLine(sum);