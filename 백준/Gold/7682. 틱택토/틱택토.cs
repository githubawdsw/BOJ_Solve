// BOJ_7682


using System.Text;

int[] dx = { 1, 0, -1, 0, 1, -1 };
int[] dy = { 0, 1, 0, -1, 1, 1 };
char[,] board = new char[3, 3];
StringBuilder sb = new StringBuilder();
while (true)
{
    string input = Console.ReadLine();
    if (input == "end")
        break;

    int xcount = 0;
    int ocount = 0;
    for (int i = 0; i < 9; i++)
    {
        if (input[i] == 'X')
            xcount++;
        else if (input[i] == 'O')
            ocount++;
    }

    if (xcount - ocount > 1 || xcount - ocount < 0)
    {
        sb.AppendLine("invalid");
        continue;
    }

    board = new char[3, 3];
    bool check = false;
    for (int i = 0; i < 3; i++)
    {
        for (int j = i * 3; j < (i + 1) * 3; j++)
        {
            board[i, j % 3] = input[j];
        }
    }

    for (int i = 0; i < 3; i++)
    {
        if ((IsSuccess('O', 0, i) || IsSuccess('O', i, 0)) && xcount == ocount)
            check = true;
    }

    if (check)
        sb.AppendLine("valid");
    else
    {
        bool oSuccess = false;
        bool xSuccess = false;
        for (int i = 0; i < 3; i++)
        {
            if ((IsSuccess('X', 0, i) || IsSuccess('X', i, 0)) && xcount > ocount)
                xSuccess = true;
            if (IsSuccess('O', 0, i) || IsSuccess('O', i, 0))
                oSuccess = true;
        }

        if (xSuccess && !oSuccess)
            sb.AppendLine("valid");

        else
        {
            check = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '.')
                        check = false;
                }
            }

            if (check && !xSuccess && !oSuccess)
                sb.AppendLine("valid");
            else
                sb.AppendLine("invalid");
        }
    }
}

Console.WriteLine(sb);

bool IsSuccess(char target, int x, int y)
{
    if (board[x, y] == '.' || board[x, y] != target)
        return false;
    for (int i = 0; i < 6; i++)
    {
        int dir = i;
        int count = 1;
        int curx = x;
        int cury = y;
        for (int j = 0; j < 3; j++)
        {
            int nx = curx + dx[dir];
            int ny = cury + dy[dir];
            if (nx < 0 || ny < 0 || nx >= 3 || ny >= 3)
                break;
            if (board[nx, ny] == target)
                count++;
            curx = nx;
            cury = ny;
        }

        if (count == 3)
            return true;
    }
    return false;
}