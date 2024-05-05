// BOJ_2567


int n = int.Parse(Console.ReadLine());

int maxx = 0; int minx = 100; int maxy = 0; int miny = 100;
bool[,] board = new bool[105, 105];
for (int i = 0; i < n; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int y = inputxy[0] + 1;
    int x = inputxy[1] + 1;

    for (int j = x; j < x + 10; j++)
    {
        for (int k = y; k < y + 10; k++)
        {
            board[j, k] = true;
        }
    }

    maxx = Math.Max(maxx, x + 10);
    minx = Math.Min(minx, x);
    maxy = Math.Max(maxy, y + 10);
    miny = Math.Min(miny, y);
}

int ans = 0;

for (int i = minx; i < maxx; i++)
{
    for (int j = miny; j < maxy; j++)
    {
        if (!board[i, j])
            continue;

        if (!board[i + 1, j])
            ans++;
        if (!board[i - 1, j])
            ans++;
        if (!board[i, j + 1])
            ans++;
        if (!board[i, j - 1])
            ans++;

    }
}

Console.WriteLine(ans);