// BOJ_14890


int[] inputnl = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = inputnl[0];
int l = inputnl[1];

int[,] board1 = new int[105, 105];
int[,] board2 = new int[105, 105];
for (int i = 0; i < n; i++)
{
    int[] inputData = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < n; j++)
	{
		board1[i, j] = inputData[j];
        board2[j, i] = inputData[j];
    }
}

int ans = Slope(board1) + Slope(board2);
Console.WriteLine(ans);


int Slope(int[,] board)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        bool use = true;
        int before = 1;
        for (int j = 0; j < n-1; j++)
        {
            if (board[i, j] == board[i, j + 1])
                before++;
            else if (board[i, j] == board[i, j + 1] + 1)
            {
                int height = board[i, j + 1];
                bool check = true;
                for (int k = j + 1; k < j + 1 + l; k++)
                {
                    if (board[i, k] != height)
                        check = false;
                }

                if (check)
                {
                    j = j + l - 1;
                    before = 0;
                }
                else
                {
                    use = false;
                    break;
                }
            }
            else if (board[i, j] + 1 == board[i, j + 1])
            {
                if(before >= l)
                {
                    before = 1;
                }
                else
                {
                    use = false;
                    break;
                }
            }
            else if (Math.Abs(board[i,j] - board[i,j + 1]) > 1)
            {
                use = false;
                break;
            }
        }
        if (use)
            count++;
    }
    return count;
}