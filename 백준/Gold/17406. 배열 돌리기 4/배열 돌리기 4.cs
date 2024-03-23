// BOJ_17406


int[] inputnmk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmk[0];
int m = inputnmk[1];
int k = inputnmk[2];

int[,] board = new int[55, 55];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
bool[] check = new bool[8];

for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        board[i,j] = inputInfo[j];
	}
}

List<(int, int, int)> list = new List<(int, int, int)>();
for (int i = 0; i < k; i++)
{
    int[] inputrot = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x = inputrot[0] - 1;
    int y = inputrot[1] - 1;
    int r = inputrot[2];
    list.Add((x, y, r));
}

int ans = int.MaxValue;
Dfs(0, board);
Console.WriteLine(ans);


void Dfs(int depth , int[,] board)
{
    if(depth == k)
    {
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                sum += board[i, j];
            }
            ans = Math.Min(ans, sum);
        }

        return;
    }


    for (int i = 0; i < k; i++)
    {
        if (check[i])
            continue;

        int[,] temp = board.Clone() as int[,];
        var cur = list[i];

        check[i] = true;
        Rotate(temp, cur);
        Dfs(depth + 1, temp);
        check[i] = false;
    }
}

void Rotate(int[,] temp, (int, int, int) center)
{
    int count = center.Item3;
    int x = center.Item1;
    int y = center.Item2;

    int[,] temp2 = temp.Clone() as int[,];
    for (int i = 1; i <= count; i++)
    {
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((x - i, y - i));
        int dir = 0;
        int start = temp2[x - i, y - i];

        while (q.Count > 0)
        {
            var cur = q.Dequeue();
            int nx = cur.Item1 + dx[dir];
            int ny = cur.Item2 + dy[dir];

            if (nx == x - i && ny == y - i)
            {
                temp[cur.Item1, cur.Item2] = start;
                break;
            }
            else if (nx > x + i)
            {
                dir = 1;
                q.Enqueue((cur.Item1, cur.Item2));
            }
            else if (ny > y + i)
            {
                dir = 2;
                q.Enqueue((cur.Item1, cur.Item2));
            }
            else if (nx < x - i)
            {
                dir = 3;
                q.Enqueue((cur.Item1, cur.Item2));
            }
            else if (ny < y - i)
            {
                dir = 0;
                q.Enqueue((cur.Item1, cur.Item2));
            }
            else
            {
                temp[cur.Item1, cur.Item2] = temp[nx, ny];
                q.Enqueue((nx, ny));
            }
        }
    }
}