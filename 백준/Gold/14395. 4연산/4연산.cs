// BOJ_14395


int[] inputst = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int s = inputst[0];
int t = inputst[1];

if(s == t)
{
    Console.WriteLine(0);
    return;
}

Queue<(long, string)> q = new Queue<(long, string)>();
HashSet<long> hs = new HashSet<long>();

q.Enqueue((s, ""));

while (q.Count > 0)
{
    var cur = q.Peek().Item1;
    var str = q.Dequeue().Item2;
    if(cur == t)
    {
        Console.WriteLine(str);
        return;
    }

    if (cur * cur <= t && cur != 1 && !hs.Contains(cur * cur))
    {
        hs.Add(cur * cur);
        q.Enqueue((cur * cur, str + "*"));
    }
    if (cur + cur <= t && !hs.Contains(cur + cur))
    {
        hs.Add(cur + cur);
        q.Enqueue((cur + cur, str + "+"));
    }
    if (cur - cur >= 0 && !hs.Contains(cur - cur))
    {
        hs.Add(cur - cur);
        q.Enqueue((cur - cur, str + "-"));
    }
    if (cur != 0 && !hs.Contains(cur / cur))
    {
        hs.Add(cur / cur);
        q.Enqueue((cur / cur, str + "/"));
    }
}

Console.WriteLine(-1);