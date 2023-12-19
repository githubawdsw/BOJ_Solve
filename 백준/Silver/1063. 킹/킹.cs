// BOJ_1063


Dictionary<string, int> dict = new Dictionary<string, int>()
{
    { "R", 0 },
    { "L", 1 },
    { "T", 2 },
    { "B", 3 },
    { "RT", 4 },
    { "LT", 5 },
    { "RB", 6 },
    { "LB", 7 }
};

int[,] board = new int[10, 10];
int[] dx = { 0, 0, 1, -1, 1, 1, -1, -1 };
int[] dy = { 1, -1, 0, 0, 1, -1, 1, -1 };

string[] inputinfo = Console.ReadLine().Split();

string king = inputinfo[0];
string stone = inputinfo[1];
int k = int.Parse(inputinfo[2]);

(int, int) kingpos = (king[1] - '1', king[0] - 'A');
(int, int) stonepos = (stone[1] - '1', stone[0] - 'A');

board[kingpos.Item1, kingpos.Item2] = 1;
board[stonepos.Item1, stonepos.Item2] = 2;

int nx = 0; int ny = 0; int sx = 0; int sy = 0;
for (int i = 0; i < k; i++)
{
    string move = Console.ReadLine();

    nx = dx[dict[move]] + kingpos.Item1;
    ny = dy[dict[move]] + kingpos.Item2;

    if (nx < 0 || ny < 0 || nx >= 8 || ny >= 8)
        continue;

    if ((nx,ny) == (stonepos.Item1,stonepos.Item2))
    {
        sx = stonepos.Item1 + dx[dict[move]];
        sy = stonepos.Item2 + dy[dict[move]];
        if (sx < 0 || sy < 0 || sx >= 8 || sy >= 8)
            continue;
        stonepos = (sx, sy);
    }
    kingpos = (nx, ny);
}

Console.WriteLine($"{(char)(kingpos.Item2 + 'A')}{(char)(kingpos.Item1 + '1')}");
Console.WriteLine($"{(char)(stonepos.Item2 + 'A')}{(char)(stonepos.Item1 + '1')}");