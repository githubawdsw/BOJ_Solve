// BOJ_2669


bool[,] board = new bool[105, 105];

for (int i = 0; i < 4; i++)
{
    int[] inputxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int x1 = inputxy[0];
    int y1 = inputxy[1];

    int x2 = inputxy[2];
    int y2 = inputxy[3];

    for (int x = x1; x < x2; x++)
    {
        for (int y = y1; y < y2; y++)
        {
            board[x, y] = true;
        }
    }
}

int ans = 0;
for (int i = 0; i <= 100; i++)
{
    for (int j = 0; j <= 100; j++)
    {
        if (board[i, j])
            ans++;
    }
}

Console.WriteLine(ans);