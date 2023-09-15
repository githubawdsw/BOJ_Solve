// BOJ_1913

using System.Text;

int N, k;
int[,] board = new int [1001,1001];

int[] ans = new int[2]; 
Queue<KeyValuePair<int, int>> Q = new Queue<KeyValuePair<int, int>>();
StringBuilder sb = new StringBuilder();

N = int.Parse(Console.ReadLine());
k = int.Parse(Console.ReadLine());
board[0, 0] = N * N;
Snail();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        sb.Append(board[i, j]);
        sb.Append(" ");
    }
    sb.AppendLine();
}
sb.Append((ans[0] + 1));
sb.Append(" ");
sb.Append((ans[1] + 1));

Console.WriteLine(sb.ToString());
        

void Snail()
{
    int[] dx = { 1, 0, -1, 0 };
    int[] dy = { 0, 1, 0, -1 };
    int r = 0;
    int c = 0;
    int d = 0;
    int count = N * N;
    while (board[N / 2, N / 2] != 1)
    {

        int nx = r + dx[d];
        int ny = c + dy[d];
        if (nx >= N || ny >= N || nx < 0 || ny < 0 || board[nx, ny] != 0)
        {
            d = (d + 1) % 4;
            continue;
        }
        count--;
        board[nx, ny] = count;
        r = nx;
        c = ny;

        if (board[nx, ny] == k)
        {
            ans[0] = nx;
            ans[1] = ny;
        }
    }

}