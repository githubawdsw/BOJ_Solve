// BOJ_1516


using System.Text;

StringBuilder sb = new StringBuilder();
int n = int.Parse(Console.ReadLine());

List<int>[] list = new List<int>[505];
int[] degree = new int[505];
int[] time = new int[505];

for (int i = 1; i <= n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    time[i] = inputInfo[0];

    for (int j = 1; inputInfo[j] != -1; j++)
	{
        int pre = inputInfo[j];
        if (list[pre] == null)
            list[pre] = new List<int>();

        list[pre].Add(i);
        degree[i]++;
	}
}

Queue<int> q = new Queue<int>();
int[] dp = new int[505];
for (int i = 1; i <= n; i++)
{
    if (degree[i] == 0)
    {
        q.Enqueue(i);
        dp[i] = time[i];
    }
}

while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (list[cur] == null)
        continue;

    foreach (var one in list[cur])
    {
        dp[one] = Math.Max(dp[one], time[one] + dp[cur]);
        degree[one]--;
        if (degree[one] == 0)
            q.Enqueue(one);
    }
}

for (int i = 1; i <= n; i++)
{
    sb.AppendLine(dp[i].ToString());
}

Console.WriteLine(sb);
