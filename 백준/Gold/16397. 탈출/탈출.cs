// BOJ_16397


int[] inputntg = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputntg[0];
int t = inputntg[1];
int g = inputntg[2];

if (n == g)
{
    Console.WriteLine(0);
    return;
}

Queue<int> q = new Queue<int>();
int[] dis = new int[100000];
q.Enqueue(n);
while (q.Count > 0)
{
    var cur = q.Dequeue();
    if (cur == g)
        break;
    if(cur + 1 < 100000 && dis[cur + 1] == 0)
    {
        dis[cur + 1] = dis[cur] + 1;
        q.Enqueue(cur + 1);
    }

    if(cur * 2 < 100000)
    {
        int nx = cur * 2;
        if (nx / 10000 != 0)
            nx -= 10000;
        else if (nx / 1000 != 0)
            nx -= 1000;
        else if (nx / 100 != 0)
            nx -= 100;
        else if (nx / 10 != 0)
            nx -= 10;
        else if (cur == 0)
            continue;
        else
            nx -= 1;

        if (dis[nx] != 0)
            continue;

        dis[nx] = dis[cur] + 1;
        q.Enqueue(nx);
    }
}

if (dis[g] <= t && dis[g] != 0)
    Console.WriteLine(dis[g]);
else
    Console.WriteLine("ANG");
