// BOJ_11969



using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnq = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnq[0];
int q = inputnq[1];

int[,] arr = new int[100005, 4];
for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    arr[i, num]++;
}

for (int i = 1; i <= n; i++)
{
    arr[i, 1] += arr[i - 1, 1];
    arr[i, 2] += arr[i - 1, 2];
    arr[i, 3] += arr[i - 1, 3];
}

for (int i = 0; i < q; i++)
{
    int[] queries = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    sb.AppendLine($"{arr[queries[1], 1] - arr[queries[0] - 1, 1]} {arr[queries[1], 2] - arr[queries[0] - 1, 2]} {arr[queries[1], 3] - arr[queries[0] - 1, 3]}");
}

Console.WriteLine(sb);
