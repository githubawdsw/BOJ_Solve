// BOJ_16948


int n = int.Parse(Console.ReadLine());

int[,] dis = new int[205, 205];
int[] dx = { 2, 2, 0, 0, -2, -2 };
int[] dy = { 1, -1, 2, -2, 1, -1 };

Queue<(int, int)> q = new Queue<(int, int)>();
int[] inputInforc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
(int, int) start = (inputInforc[0], inputInforc[1]);
(int, int) end = (inputInforc[2], inputInforc[3]);
q.Enqueue(start);

while (q.Count > 0)
{
	var cur = q.Dequeue();
	for (int i = 0; i < 6; i++)
	{
		int nx = dx[i] + cur.Item1;
		int ny = dy[i] + cur.Item2;
		if (nx < 0 || ny < 0 || nx >= n || ny >= n)
			continue;
		if (dis[nx, ny] != 0)
			continue;

		dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;
		q.Enqueue((nx, ny));
	}
}


if(dis[end.Item1, end.Item2] == 0)
    Console.WriteLine(-1);
else
	Console.WriteLine(dis[end.Item1, end.Item2]);
