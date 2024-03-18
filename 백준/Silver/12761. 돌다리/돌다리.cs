// BOJ_12761



int[] inputabnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = inputabnm[0];
int b = inputabnm[1];
int n = inputabnm[2];
int m = inputabnm[3];

Queue<int> q = new Queue<int>();
int[] dis = new int[100005];
int[] dx = { 1, -1, a, -a, b, -b, a, b };

int ans = 0;
dis[n] = 1;
q.Enqueue(n);
while (q.Count > 0)
{
    var cur = q.Dequeue();
	for (int i = 0; i < 8; i++)
	{
		int nx;
		if (i < 6)
			nx = cur + dx[i];
		else
			nx = cur * dx[i];

		if (nx < 0 || nx > 100000 || dis[nx] > 0)
			continue;

		dis[nx] = dis[cur] + 1;
			
		q.Enqueue(nx);
    }
}

Console.WriteLine(dis[m] - 1);