// BOJ_16439


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

List<int[]> list = new List<int[]>();
for (int i = 0; i < n; i++)
{
    int[] inputPrefer = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    list.Add(inputPrefer);
}

int ans = 0;

for (int i = 0; i < m - 2; i++)
{
    for (int j = i + 1; j < m - 1; j++)
    {
        for (int k = j + 1; k < m; k++)
        {
            int sum = 0;
            for (int idx = 0; idx < n; idx++)
            {
                int max = Math.Max(list[idx][i], list[idx][j]);
                max = Math.Max(max, list[idx][k]);
                sum += max;
            }
            ans = Math.Max(ans, sum);
        }
    }
}

Console.WriteLine(ans);