// BOJ_16953


string[] inputab = Console.ReadLine().Split(' ');
int a = int.Parse(inputab[0]);
int b = int.Parse(inputab[1]);


Queue<Tuple<long, long>> q = new Queue<Tuple<long, long>>();
q.Enqueue(new Tuple<long, long>( a , 0));
long ans = int.MaxValue;
while (q.Count > 0)
{
    var cur = q.Dequeue();
    bfs(cur.Item1 * 2 , cur.Item2);
    bfs(cur.Item1 * 10 + 1 , cur.Item2);
}

if (ans == int.MaxValue)
    ans = -2;
Console.WriteLine(  ans + 1);


void bfs(long x , long c)
{
    if (x > b)
        return;
    if(x == b)
    {
        ans = Math.Min( c + 1 , ans);
        return;
    }
    q.Enqueue(new Tuple<long, long>(x , c + 1));
}