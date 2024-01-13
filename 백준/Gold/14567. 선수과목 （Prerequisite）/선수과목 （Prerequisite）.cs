// BOJ_14567


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[] dp = new int[1005];
int[] degree = new int[1005];
List<int>[] list = new List<int>[1005];
Queue<int> q = new Queue<int>();
Array.Fill(dp, 1);

for (int i = 0; i < m; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int front = inputInfo[0];
    int back = inputInfo[1];
    if (list[front] == null)
        list[front] = new List<int>();
    list[front].Add(back);
    degree[back]++;
}

for (int i = 1; i <= n; i++)
{
    if (degree[i] == 0)
        q.Enqueue(i);
}

while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (list[cur] == null)
        continue;
    foreach (var one in list[cur])
    {
        degree[one]--;
        dp[one] = Math.Max(dp[one], dp[cur] + 1);
        if (degree[one] == 0)
            q.Enqueue(one);
    }
}

for (int i = 1; i <= n; i++)
{
    sb.Append($"{dp[i]} ");
}
Console.WriteLine(sb);