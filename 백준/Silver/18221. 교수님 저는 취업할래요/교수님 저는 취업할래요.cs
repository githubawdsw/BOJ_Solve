// BOJ_18221


int n = int.Parse(Console.ReadLine());
int[,] board = new int[1005, 1005];
Tuple<int, int> seong = null;
Tuple<int, int> professor = null;
for (int i = 0; i < n; i++)
{
    int[] inputval = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < n; j++)
    {
        board[i, j] = inputval[j];
        if (board[i, j] == 2)
            seong = new (i, j);
        if (board[i, j] == 5)
            professor = new(i, j);
    }
}

int maxx = Math.Max(seong.Item1, professor.Item1);
int minx = Math.Min(seong.Item1, professor.Item1);
int maxy = Math.Max(seong.Item2, professor.Item2);
int miny = Math.Min(seong.Item2, professor.Item2);


if((maxx - minx) * (maxx - minx) + (maxy - miny) * (maxy - miny) < 25)
{
    Console.WriteLine(0);
    return;
}

int count = 0;
for (int i = minx; i <= maxx; i++)
{
    for (int j = miny; j <= maxy; j++)
    {
        if (board[i, j] == 1)
            count++;
    }
}

if(count >= 3)
    Console.WriteLine(1);
else
    Console.WriteLine(0);