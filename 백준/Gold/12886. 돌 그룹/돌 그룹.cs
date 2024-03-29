// BOJ_12886


int[] inputabc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(inputabc, 0, 3);
int a = inputabc[0];
int b = inputabc[1];
int c = inputabc[2];

bool[] used = new bool[5];

Dictionary<(int, int), bool> dict = new Dictionary<(int, int), bool>();
dict.Add((a, b), true);
if(!dict.ContainsKey((b,c)))
    dict.Add((b, c), true);
if (!dict.ContainsKey((a, c)))
    dict.Add((a, c), true);
Queue<(int, int, int)> q = new Queue<(int, int, int)>();
q.Enqueue((a, b, c));

if ((a + b + c) % 3 != 0)
{
    Console.WriteLine(0);
    return;
}

int ans = 0;
while (q.Count > 0)
{
    var cur = q.Dequeue();

    if (cur.Item1 == cur.Item2 && cur.Item2 == cur.Item3)
    {
        ans = 1;
        break;
    }

    if(cur.Item1 != cur.Item2)
    {
        int x = cur.Item1 > cur.Item2 ? cur.Item1 - cur.Item2 : cur.Item1 * 2;
        int y = cur.Item2 > cur.Item1 ? cur.Item2 - cur.Item1 : cur.Item2 * 2;
        if (!dict.ContainsKey((x, y)))
        {
            q.Enqueue((x, y, cur.Item3));
            dict.Add((x, y), true);
        }
    }
    if (cur.Item1 != cur.Item3)
    {
        int x = cur.Item1 > cur.Item3 ? cur.Item1 - cur.Item3 : cur.Item1 * 2;
        int y = cur.Item3 > cur.Item1 ? cur.Item3 - cur.Item1 : cur.Item3 * 2;
        if (!dict.ContainsKey((x, y)))
        {
            q.Enqueue((x, cur.Item2, y));
            dict.Add((x, y), true);
        }
    }
    if (cur.Item2 != cur.Item3)
    {
        int x = cur.Item2 > cur.Item3 ? cur.Item2 - cur.Item3 : cur.Item2 * 2;
        int y = cur.Item3 > cur.Item2 ? cur.Item3 - cur.Item2 : cur.Item3 * 2;
        if (!dict.ContainsKey((x, y)))
        {
            q.Enqueue((cur.Item1, x, y));
            dict.Add((x, y), true);
        }
    }
}

Console.WriteLine(ans);