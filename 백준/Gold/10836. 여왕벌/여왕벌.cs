// BOJ_10836


using System.Text;

StringBuilder sb = new StringBuilder();
int[] inputmn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int m = inputmn[0];
int n = inputmn[1];

int[,] sum = new int[705, 705];
int[,] board = new int[705,705];
for (int i = 0; i < n; i++)
{
    int[] inputLarva = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    (int, int) dir = (-1, 0);
    (int, int) pos = (m, 0);
    for (int j = 0; j < 3; j++)
	{
        int k = 0;
        while (k++ != inputLarva[j])
        {
            if(pos.Item1 + dir.Item1 < 0)
            {
                k--;
                dir = (0, 1);
                continue;
            }
            pos = (pos.Item1 + dir.Item1, pos.Item2 + dir.Item2);
            sum[pos.Item1, pos.Item2] += j;
        }
	}

}

for (int i = 1; i < m; i++)
{
    for (int j = 1; j < m; j++)
    {
        sum[i, j] = Math.Max(Math.Max(sum[i - 1, j], sum[i, j - 1]), sum[i - 1, j - 1]);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        board[i, j] = sum[i, j] + 1;
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        sb.Append(board[i, j] + " ");
    }
    sb.AppendLine();
}

Console.WriteLine(sb);