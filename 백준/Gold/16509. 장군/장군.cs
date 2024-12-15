// BOJ_16509


int[] inputStartPos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputStartPos[0];
int c = inputStartPos[1];

int[] endPos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

(int, int)[][] move = new (int, int)[8][];
move[0] = new (int, int)[] { (-1, 0), (-2, -1), (-3, -2) };
move[1] = new (int, int)[] { (-1, 0), (-2, 1), (-3, 2) };
move[2] = new (int, int)[] { (1, 0), (2, -1), (3, -2) };
move[3] = new (int, int)[] { (1, 0), (2, 1), (3, 2) };
move[4] = new (int, int)[] { (0, -1), (-1, -2), (-2, -3) };
move[5] = new (int, int)[] { (0, -1), (1, -2), (2, -3) };
move[6] = new (int, int)[] { (0, 1), (-1, 2), (-2, 3) };
move[7] = new (int, int)[] { (0, 1), (1, 2), (2, 3) };

int[,] dis = new int[10, 10];
dis[r, c] = 1;
Queue<(int, int)> q = new Queue<(int, int)>();
q.Enqueue((r, c));

while (q.Count > 0)
{
    var cur = q.Dequeue();
    for (int i = 0; i < 8; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			var target = move[i][j];
			int nx = cur.Item1 + target.Item1;
			int ny = cur.Item2 + target.Item2;

			if (nx < 0 || ny < 0 || nx >= 10 || ny >= 9)
				break;

			if (j < 2 && nx == endPos[0] && ny == endPos[1])
				break;

			if (j == 2)
			{
				if (dis[nx, ny] > 0)
					break;

				if(nx == endPos[0] && ny == endPos[1])
				{
					Console.WriteLine(dis[cur.Item1, cur.Item2]);
                    return;
				}
				dis[nx, ny] = dis[cur.Item1, cur.Item2] + 1;
				q.Enqueue((nx, ny));
			}
		}
	}
}

Console.WriteLine(-1);