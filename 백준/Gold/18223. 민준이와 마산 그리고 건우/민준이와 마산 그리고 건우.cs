// BOJ_18223


string[] inputvep = Console.ReadLine().Split(' ');
int v = int.Parse(inputvep[0]);
int e = int.Parse(inputvep[1]);
int p = int.Parse(inputvep[2]);

List<Tuple<int, int>>[] tupleList = new List<Tuple<int, int> >[5005];
for (int i = 0; i < e; i++)
{
    string[] inputabc = Console.ReadLine().Split(' ');
    int a = int.Parse(inputabc[0]);
    int b = int.Parse(inputabc[1]);
    int c = int.Parse(inputabc[2]);
    if (tupleList[a] == null)
        tupleList[a] = new List<Tuple<int, int>>();
    tupleList[a].Add(new Tuple<int, int>(b , c));
    if (tupleList[b] == null)
        tupleList[b] = new List<Tuple<int, int>>();
    tupleList[b].Add(new Tuple<int, int>(a, c));
}

int[] dp = new int[5005];
Array.Fill(dp, int.MaxValue / 2);
dp[1] = 0;
solve(1);

int starttoend = dp[v];
int starttomiddle = dp[p];

Array.Fill(dp, int.MaxValue / 2);
dp[p] = 0;
solve(p);
int middletoend = dp[v];
if (starttoend == starttomiddle + middletoend)
    Console.WriteLine("SAVE HIM");
else
    Console.WriteLine("GOOD BYE");


void solve(int start)
{
    PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
    pq.Enqueue(new Tuple<int, int>(start, 0), 0);
    while (pq.Count != 0)
    {
        var cur = pq.Dequeue();
        if (tupleList[cur.Item1] == null)
            continue;
        if (dp[cur.Item1] != cur.Item2)
            continue;
        foreach (var one in tupleList[cur.Item1])
        {
            if (dp[one.Item1] > one.Item2 + dp[cur.Item1])
            {
                dp[one.Item1] = one.Item2 + dp[cur.Item1];
                pq.Enqueue(new Tuple<int, int>(one.Item1, dp[one.Item1]), dp[one.Item1]);
            }
        }
    }
}