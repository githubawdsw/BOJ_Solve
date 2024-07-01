// BOJ_16927


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnmr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmr[0];
int m = inputnmr[1];
int r = inputnmr[2];

int[,] board = new int[305, 305];
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
    {
        board[i,j] = inputInfo[j];
    }
}


for (int i = 0; i < n / 2 && i < m / 2; i++)
{
    int count = (n + m - 4 * i) * 2 - 4;
    count = r % count;
    while (count-- > 0)
    {
        Rotate(i, i);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sb.Append($"{board[i, j]} ");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);


void Rotate(int x, int y)
{
    int start = board[x, y];
    (int, int) pos = (x, y);
    while (pos.Item2 + 1 < m - y)
    {
        board[x, pos.Item2] = board[x, pos.Item2 + 1];
        pos = (x, pos.Item2 + 1);
    }

    while (pos.Item1 + 1 < n - x)
    {
        board[pos.Item1, pos.Item2] = board[pos.Item1 + 1, pos.Item2];
        pos = (pos.Item1 + 1, pos.Item2);
    }

    while (pos.Item2 - 1 >= y)
    {
        board[pos.Item1, pos.Item2] = board[pos.Item1, pos.Item2 - 1];
        pos = (pos.Item1, pos.Item2 - 1);
    }

    while (pos.Item1 - 1 >= x + 1)
    {
        board[pos.Item1, pos.Item2 ] = board[pos.Item1 - 1, pos.Item2];
        pos = (pos.Item1 - 1, pos.Item2);
    }
    board[x + 1, y] = start;
}