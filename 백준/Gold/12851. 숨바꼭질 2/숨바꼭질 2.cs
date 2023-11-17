// BOJ_12851



string[] inputnk = Console.ReadLine().Split(' ');
int n = int.Parse(inputnk[0]);
int k = int.Parse(inputnk[1]);

if(n == k)
{
    Console.WriteLine(0);
    Console.WriteLine(	1);
    return;
}

int[] dx = { 1, -1, 2 };
Queue<int> q = new Queue<int>();
int[] dis = new int[200005];
int[] count = new int[200005];
q.Enqueue(n);
dis[n] = 1;
count[n] = 1;
while (q.Count > 0)
{
    var cur = q.Dequeue();
	for (int i = 0; i < 3; i++)
	{
		int nx;
		if (i != 2)
			nx = dx[i] + cur;
		else
			nx = dx[i] * cur;
		if (nx < 0 || nx > 200000 )
			continue;

		if (dis[nx] == dis[cur] + 1 )
			count[nx] += count[cur];

		if (dis[nx] == 0)
		{
			q.Enqueue(nx);
			count[nx] = count[cur];
			dis[nx] = dis[cur] + 1;
		}
	}
}

Console.WriteLine(dis[k] - 1 );
Console.WriteLine(count[k] );
