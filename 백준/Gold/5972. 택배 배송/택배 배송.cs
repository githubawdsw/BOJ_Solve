// BOJ_5972


using System.Text;

StringBuilder sb= new StringBuilder();

string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m  = int.Parse(inputnm[1]);

List<Tuple<int, int>>[] tupleList = new List<Tuple<int, int>>[50005];
for (int i = 0; i < m; i++)
{
    string[] inputabc = Console.ReadLine().Split(' ');
    int a = int.Parse(inputabc[0]);
    int b = int.Parse(inputabc[1]);
    int c = int.Parse(inputabc[2]);
    if (tupleList[a] == null)
        tupleList[a] = new List<Tuple<int, int>>();
    tupleList[a].Add(new Tuple<int, int>(c, b));
    if (tupleList[b] == null)
        tupleList[b] = new List<Tuple<int, int>>();
    tupleList[b].Add(new Tuple<int, int>(c, a));

}

int[] dp = new int[50005];
Array.Fill(dp, int.MaxValue / 2);
dp[1] = 0;

PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
pq.Enqueue(new Tuple<int, int>(0, 1), 0);

while (pq.Count > 0)
{
    var cur = pq.Dequeue();
    if (tupleList[cur.Item2] == null)
        continue;
    if (dp[cur.Item2] != cur.Item1)
        continue;
    foreach (var one in tupleList[cur.Item2])
    {
        if (dp[one.Item2] > one.Item1 + dp[cur.Item2])
        {
            dp[one.Item2] = one.Item1 + dp[cur.Item2];
            pq.Enqueue(new Tuple<int, int>(dp[one.Item2], one.Item2), one.Item2);
        }
    }
}


Console.WriteLine(dp[n]);
