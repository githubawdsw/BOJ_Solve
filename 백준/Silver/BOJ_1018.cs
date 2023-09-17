// BOJ_1018



string[] inputnm = Console.ReadLine().Split(' ');
int n = int.Parse(inputnm[0]);
int m  = int.Parse(inputnm[1]);

char[,] blackstart = {
    { 'B','W','B','W','B','W','B','W' },
    { 'W','B','W','B','W','B','W','B' },
    { 'B','W','B','W','B','W','B','W' },
    { 'W','B','W','B','W','B','W','B' },
    { 'B','W','B','W','B','W','B','W' },
    { 'W','B','W','B','W','B','W','B'},
    { 'B','W','B','W','B','W','B','W' },
    { 'W','B','W','B','W','B','W','B' }
};
char[,] whitestart = {
    { 'W','B','W','B','W','B','W','B' },
    { 'B','W','B','W','B','W','B','W' },
    { 'W','B','W','B','W','B','W','B' },
    { 'B','W','B','W','B','W','B','W' },
    { 'W','B','W','B','W','B','W','B'},
    { 'B','W','B','W','B','W','B','W' },
    { 'W','B','W','B','W','B','W','B' },
    { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' }
};

char[,] board = new char[53, 53];
for (int i = 0; i < n; i++)
{
    string inputbw = Console.ReadLine();
	for (int j = 0; j < m; j++)
		board[i,j] = inputbw[j];
}

int bcount = 0;
int wcount = 0;
int ans = int.MaxValue;
for (int i = 0; i <= n - 8; i++)
{
    for (int j = 0; j <= m- 8; j++)
    {
        bcount = black_first(i, j);
        wcount = white_first(i, j);
        if (bcount < wcount)
            ans = Math.Min(ans, bcount);
        else
            ans = Math.Min(ans, wcount);
    }
}
Console.WriteLine( ans );

int white_first(int x, int y)
{
    int count = 0;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (whitestart[i,j] != board[i + x, j + y])
                count++;
        }
    }
    return count;
}

int black_first(int x, int y)
{
    int count = 0;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (blackstart[i, j] != board[i + x, j + y])
                count++;
        }
    }
    return count;
}

