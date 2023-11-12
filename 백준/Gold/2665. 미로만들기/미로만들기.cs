// BOJ_2665


int n = int.Parse(Console.ReadLine());
char[,] room = new char[55, 55];
int[] dx = { 1, -1, 0, 0 };
int[] dy = { 0, 0 ,1, -1  };
int[][] roomcounting = new int[55][];

for (int i = 0; i < n; i++)
{
	string inputroom = Console.ReadLine();
    for (int j = 0; j < n; j++)
		room[i, j] = inputroom[j];
}
for (int i = 0; i < n; i++)
{
	roomcounting[i] = new int[55];
	Array.Fill(roomcounting[i], int.MaxValue / 2);
}

PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
pq.Enqueue(new Tuple<int, int>(0, 0) , 0);
roomcounting[0][0] = 0;
while (pq.Count != 0)
{
	Tuple<int, int> cur = pq.Dequeue();
	for (int i = 0; i < 4; i++)
	{
		int nx = cur.Item1 + dx[i];
        int ny = cur.Item2 + dy[i];
		if (nx < 0 || ny < 0 || nx >= n || ny >= n || 
			roomcounting[nx][ny] <= roomcounting[cur.Item1][cur.Item2])
			continue;
		if (room[nx, ny] == '0' && roomcounting[nx][ny] > roomcounting[cur.Item1][cur.Item2])
			roomcounting[nx][ny] = roomcounting[cur.Item1][cur.Item2] + 1;
		else
            roomcounting[nx][ny] = roomcounting[cur.Item1][cur.Item2];
		pq.Enqueue(new Tuple<int, int>(nx, ny), roomcounting[nx][ny]);
    }
}
Console.WriteLine(roomcounting[n-1][n-1]);

