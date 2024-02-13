// BOJ_2210


char[,] board = new char[5, 5];
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
HashSet<string> hs = new HashSet<string>();
char[] arr = new char[6];

for (int i = 0; i < 5; i++)
{
    char[] inputsb = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);
    for (int j = 0; j < 5; j++)
    {
        board[i, j] = inputsb[j];
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        dfs(0, i, j);
    }
}

Console.WriteLine(hs.Count);



void dfs(int depth, int x ,int y)
{
    if(depth == 6)
    {
        hs.Add(new string(arr));
        return;
    }

    for (int i = 0; i < 4; i++)
    {
        int nx = dx[i] + x;
        int ny = dy[i] + y;

        if (nx < 0 || ny < 0 || nx >= 5 || ny >= 5)
            continue;

        arr[depth] = board[x, y];
        dfs(depth + 1, nx, ny);
    }
}

