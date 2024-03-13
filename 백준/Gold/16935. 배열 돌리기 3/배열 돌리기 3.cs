// BOJ_16935


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputnmr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnmr[0];
int m = inputnmr[1];
int r = inputnmr[2];

int[,] board = new int[105, 105];
for (int i = 0; i < n; i++)
{
    int[] inputInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++)
	{
        board[i,j] = inputInfo[j];
	}
}

int[] op = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < r; i++)
{
    if (op[i] == 1)
        UpDownReversal();
    else if (op[i] == 2)
        LeftRightReversal();
    else if (op[i] == 3)
        RightRotate();
    else if (op[i] == 4)
        LeftRotate();
    else if (op[i] == 5)
        GroupRightRotate();
    else if (op[i] == 6)
        GroupLeftRotate();
}

int max = Math.Max(n, m);
for (int i = 0; i < max; i++)
{
    for (int j = 0; j < max; j++)
    {
        if (board[i,j] != 0)
            sb.Append(board[i,j] + " ");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);


void UpDownReversal()
{
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = 0; j < m; j++)
        {
            (board[i, j], board[n - 1 - i, j]) = (board[n - 1 - i, j], board[i, j]);
        }
    }
}

void LeftRightReversal()
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m / 2; j++)
        {
            (board[i, j], board[i, m - 1 - j]) = (board[i, m - 1 - j], board[i, j]);
        }
    }
}

void RightRotate()
{
    int[,] temp = new int[105, 105];
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = i; j < m - i - 1; j++)
        {
            temp[j, n - i - 1] = board[i, j];
            temp[m - j - 1, i] = board[n - i - 1, m - j - 1];
        }
    }
    for (int i = 0; i < m / 2; i++)
    {
        for (int j = i; j < n - i - 1; j++)
        {
            temp[m - i - 1, n - j - 1] = board[j, m - i - 1];
            temp[i, j] = board[n - j - 1, i];
        }
    }
    board = temp;
    (n, m) = (m, n);
}

void LeftRotate()
{
    int[,] temp = new int[105, 105];
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = i; j < m - i - 1; j++)
        {
            temp[m - j - 1, i] = board[i, j];
            temp[j, n - i - 1] = board[n - i - 1, m - j - 1];
        }
    }
    for (int i = 0; i < m / 2; i++)
    {
        for (int j = i; j < n - i - 1; j++)
        {
            temp[i, j] = board[j, m - i - 1];
            temp[m - i - 1, n - j - 1] = board[n - j - 1, i];
        }
    }
    board = temp;
    (n, m) = (m, n);
}
void GroupRightRotate()
{
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = 0; j < m / 2; j++)
        {
            (board[i, j], board[i, j + m / 2], board[i + n / 2, j + m / 2], board[i + n / 2, j])
                = (board[i + n / 2, j], board[i, j], board[i, j + m / 2], board[i + n / 2, j + m / 2]);
        }
    }
}

void GroupLeftRotate()
{
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = 0; j < m / 2; j++)
        {
            (board[i, j], board[i, j + m / 2], board[i + n / 2, j + m / 2], board[i + n / 2, j])
                = (board[i, j + m / 2], board[i + n / 2, j + m / 2], board[i + n / 2, j], board[i, j]);
        }
    }
}
