// BOJ_11657

using System.Text;

string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);  
int m = int.Parse(inputnm[1]);

StringBuilder sb = new StringBuilder();
List<Tuple<int, int>>[] tupleList = new List<Tuple<int, int>>[505];

for (int i = 0; i < m; i++)
{
    string[] inputabc = Console.ReadLine().Split(' ');
    int a = int.Parse(inputabc[0]);
    int b = int.Parse(inputabc[1]);
    int c = int.Parse(inputabc[2]);
    if (tupleList[a] == null)
        tupleList[a] = new List<Tuple<int, int>>();
    tupleList[a].Add(new Tuple<int, int>(b, c));
}

long[] dis = new long[n+1];
Array.Fill(dis, int.MaxValue);

if (bellmanFord(1, n) != -1)
    for (long i = 2; i <= n; i++)
    {
        if (dis[i] == int.MaxValue)
            sb.AppendLine("-1");
        else
            sb.AppendLine(dis[i].ToString());
    }
else
    sb.AppendLine("-1");

Console.WriteLine(  sb);

int bellmanFord(long start , long end)
{
    dis[start] = 0;
    for (long i = 1; i <= end; i++)
    {
        for (long cur = 1; cur <= end; cur++)
        {
            if (dis[cur] == int.MaxValue)
                continue;
            if (tupleList[cur] == null)
                continue;
            foreach (var one in tupleList[cur])
            {
                long next = one.Item1;
                long nextCost = one.Item2;
                if (dis[next] > dis[cur] + nextCost)
                {
                    dis[next] = dis[cur] + nextCost;
                    if (i == end)
                        return -1;
                }
            }
        }
    }
    return 1;
}

