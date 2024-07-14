// BOJ_1986


int[] inputnm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnm[0];
int m = inputnm[1];

int[,] board = new int[1005, 1005];
List<(char,int, int)> list = new List<(char, int, int)>();
int[] dx = { 1, 0, -1, 0, 1, 1, -1, -1 };
int[] dy = { 0, 1, 0, -1, 1, -1, 1, -1 };

int[] inputQueen = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 1; i <= inputQueen[0]; i++)
{
    int idx = 2 * i - 1;
    list.Add(('Q', inputQueen[idx], inputQueen[idx + 1]));
    board[inputQueen[idx], inputQueen[idx + 1]] = 3;
}

int[] inputKnight = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 1; i <= inputKnight[0]; i++)
{
    int idx = 2 * i - 1;
    list.Add(('K', inputKnight[idx], inputKnight[idx + 1]));
    board[inputKnight[idx], inputKnight[idx + 1]] = 3;
}

int[] inputPawn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 1; i <= inputPawn[0]; i++)
{
    int idx = 2 * i - 1;
    list.Add(('P', inputPawn[idx], inputPawn[idx + 1]));
    board[inputPawn[idx], inputPawn[idx + 1]] = 3;
}

foreach (var one in list)
{
    int nx;
    int ny;
    if(one.Item1 == 'K')
    {
        nx = one.Item2 + 2;
        ny = one.Item3 + 1;
        if (check(nx, ny))
            board[nx, ny] = 2;

        nx = one.Item2 + 2;
        ny = one.Item3 - 1;
        if (check(nx, ny))
            board[nx, ny] = 2;

        nx = one.Item2 + 1;
        ny = one.Item3 + 2;
        if (check(nx, ny))
            board[nx, ny] = 2;

        nx = one.Item2 + 1;
        ny = one.Item3 - 2;
        if (check(nx, ny))
            board[nx, ny] = 2;

        nx = one.Item2 - 2;
        ny = one.Item3 + 1;
        if (check(nx, ny))
            board[nx, ny] = 2;

        nx = one.Item2 - 2;
        ny = one.Item3 - 1;
        if (check(nx, ny))
            board[nx, ny] = 2;

        nx = one.Item2 - 1;
        ny = one.Item3 + 2;
        if (check(nx, ny))
            board[nx, ny] = 2;

        nx = one.Item2 - 1;
        ny = one.Item3 - 2;
        if (check(nx, ny))
            board[nx, ny] = 2;
    }

    if(one.Item1 == 'Q')
    {
        for (int i = 0; i < 8; i++)
        {
            nx = one.Item2;
            ny = one.Item3;
            for (int j = 0; j < 1000; j++)
            {
                if (!check(nx + dx[i], ny + dy[i]))
                    break;

                nx += dx[i];
                ny += dy[i];
                board[nx, ny] = 2;
            }
        }
    }
}

int ans = 0;
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= m; j++)
    {
        if (board[i, j] == 0)
            ans++;
    }
}

Console.WriteLine(ans);


bool check(int x, int y)
{
    if (x <= 0 || y <= 0 || x > n || y > m || board[x,y] == 3)
        return false;
    return true;
}