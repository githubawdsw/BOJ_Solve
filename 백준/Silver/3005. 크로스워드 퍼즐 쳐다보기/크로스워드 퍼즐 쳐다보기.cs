// BOJ_3005


using System.Text;

int[] inputrc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int r = inputrc[0];
int c = inputrc[1];

char[,] board = new char[21, 21];
List<(int, int)> list = new List<(int, int)>();
SortedSet<string> ss = new SortedSet<string>();
for (int i = 0; i < r; i++)
{
	string inputArr = Console.ReadLine();
	for (int j = 0; j < c; j++)
	{
		board[i, j] = inputArr[j];
		if (inputArr[j] != '#')
			list.Add((i, j));
	}
}

SetAdd((1, 0));
SetAdd((0, 1));

Console.WriteLine(ss.First());


void SetAdd((int, int) dir)
{
	for (int i = 0; i < list.Count; i++)
	{
		var cur = list[i];

		int nx = cur.Item1 + dir.Item1;
		int ny = cur.Item2 + dir.Item2;

        if (cur.Item1 - dir.Item1 < 0 || cur.Item2 - dir.Item2 < 0 ||
            board[cur.Item1 - dir.Item1, cur.Item2 - dir.Item2] == '#')
		{
            if (nx >= r || ny>= c || board[nx, ny] == '#')
                continue;

            StringBuilder sb = new StringBuilder();
            sb.Append(board[cur.Item1, cur.Item2]);
            while (nx < r && ny < c && board[nx, ny] != '#')
            {
                sb.Append(board[nx, ny]);
                nx += dir.Item1;
                ny += dir.Item2;
            }
            ss.Add(sb.ToString());
        }
    }
}

