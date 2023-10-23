// BOJ_1916


List<Tuple<int, int>>[] tupleList = new List<Tuple<int, int>>[1005];

int n = int.Parse(Console.ReadLine()); 
int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    string[] inputsec = Console.ReadLine().Split(' ');
    int s = int.Parse(inputsec[0]);
    int e = int.Parse(inputsec[1]);
    int c = int.Parse(inputsec[2]);
    if (tupleList[s] == null)
        tupleList[s] = new List<Tuple<int, int>>();
    tupleList[s].Add(new Tuple<int, int>( c, e));
}

string[] startend = Console.ReadLine().Split(' ');
int start = int.Parse(startend[0]);
int end = int.Parse(startend[1]);

int[] d = new int[1005];
Array.Fill(d, int.MaxValue / 2);
d[start] = 0;

PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
pq.Enqueue(new Tuple<int, int>(d[start], start), d[start]);
while (pq.Count != 0)
{
    var cur = pq.Dequeue();
    if (tupleList[cur.Item2] == null)
        continue;
    if (d[cur.Item2] != cur.Item1)
        continue;
    foreach (var one in tupleList[cur.Item2])
    {
        if (d[one.Item2] > d[cur.Item2] + one.Item1)
        {
            d[one.Item2] = d[cur.Item2] + one.Item1;
            pq.Enqueue(new Tuple<int, int>(d[one.Item2], one.Item2), d[one.Item2]);
        }
    }
}
Console.WriteLine(d[end]);
