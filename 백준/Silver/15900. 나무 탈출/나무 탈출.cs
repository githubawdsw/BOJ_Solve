// BOJ_15900

int n = int.Parse(Console.ReadLine());
List<int>[] arrList = new List<int>[500005];
bool[] vis = new bool[500005];

for (int i = 0; i < n-1; i++)
{
    string[] inputab = Console.ReadLine().Split(' ');
    int a = int.Parse(inputab[0]);
    int b = int.Parse(inputab[1]);
    if (arrList[a] == null)
        arrList[a] = new List<int>();
    arrList[a].Add(b);
    if (arrList[b] == null)
        arrList[b] = new List<int>();
    arrList[b].Add(a);
}

int ans = 0;
Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
q.Enqueue(new Tuple<int, int>(1 , 0));
vis[1] = true;
while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (cur.Item1 != 1 && arrList[cur.Item1].Count == 1)
    {
        ans += cur.Item2;
    }
    foreach (var one in arrList[cur.Item1])
    {
        if (vis[one])
            continue;
        vis[one] = true;
        q.Enqueue(new Tuple<int, int>( one , cur.Item2 + 1));
    }
}

if(ans % 2 == 0)
    Console.WriteLine(  "No");
else
    Console.WriteLine(  "Yes");